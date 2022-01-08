using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Statement
{
	public abstract class Assignment
	{
		protected Variables.Variable _assignee;

		protected Assignment(ref Variables.Variable res)
		{
			_assignee = res;
		}

		public abstract void Evaluate();
	}

	public class VariableAssignment : Assignment
	{
		private readonly Variables.Variable _operandA;

		public VariableAssignment(ref Variables.Variable res, in Variables.Variable opA) : base(ref res)
		{
			_operandA = opA;
		}

		public override void Evaluate()
		{
			_assignee = _operandA;
		}
	}

	public abstract class Statement
	{
		public abstract Variables.Variable Evaluate();
	}

	public class UnaryStatement : Statement
	{
		private readonly Operators.UnaryOperator _op;
		private readonly Variables.Variable _operandA;


		public UnaryStatement(in Operators.UnaryOperator op, in Variables.Variable opA) : base()
		{
			_op = op;
			_operandA = opA;
		}

		public override Variables.Variable Evaluate()
		{
			return _op.Execute(_operandA);
		}
	}

	public class BinaryStatement : Statement
	{
		private readonly Operators.BinaryOperator _op;
		private readonly Variables.Variable _operandA;
		private readonly Variables.Variable _operandB;


		public BinaryStatement(in Operators.BinaryOperator op, in Variables.Variable opA, in Variables.Variable opB) : base()
		{
			_op = op;
			_operandA = opA;
			_operandB = opB;
		}

		public override Variables.Variable Evaluate()
		{
			return _op.Execute(_operandA, _operandB);
		}
	}

	public class StatementAssignment : Assignment
	{
		private readonly Statement _statement;

		public StatementAssignment(ref Variables.Variable res, in Statement s) : base(ref res)
		{
			_statement = s;
		}

		public override void Evaluate()
		{
			_assignee = _statement.Evaluate();
		}
	}
}
