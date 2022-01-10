using Model.Variables.Variables;

namespace Model.Variables.Statement
{
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
			if (!op.SupportsArgument(opA))
			{
				throw new System.InvalidOperationException("Operation only supports arguments of type: " +
					op.SupportedArgumentTypes().ToString());
			}

			_op = op;
			_operandA = opA;
		}

		public HashSet<VariableType> ReturnType() => _op.SupportedReturnTypes(_operandA);

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
			if (!op.SupportsArguments(opA, opB))
			{
				throw new System.InvalidOperationException("Operation only supports arguments of type: " + 
					op.SupportedLeftArgumentTypes().Union(op.SupportedRightArgumentTypes()).ToString() );
			}

			_op = op;
			_operandA = opA;
			_operandB = opB;
		}

		public HashSet<VariableType> ReturnType() => _op.SupportedReturnTypes(_operandA, _operandB);

		public override Variables.Variable Evaluate()
		{
			return _op.Execute(_operandA, _operandB);
		}
	}

}
