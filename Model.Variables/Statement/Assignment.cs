using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Statement
{
	public abstract class Assignment
	{
		protected readonly Variables.VariableName _resultVarName;

		protected Assignment(in Variables.VariableName resName)
		{
			_resultVarName = resName;
		}

		protected bool Check(Variables.VariableTable varTable, Variables.VariableName varName)
		{
			return varTable.ContainsKey(varName);
		}

		public abstract Variables.VariableTable Evaluate(Variables.VariableTable varTable);
	}

	public class VariableTypeMismatchException : Exception
	{
		public VariableTypeMismatchException(Variables.VariableName assignee) : 
			base("Types of result varaible " + assignee.ToString() + " and the result of the statement does not match")
		{

		}
	}

	public class VariableAssignment : Assignment
	{
		private readonly Variables.VariableName _operandAVarName;

		public VariableAssignment(in Variables.VariableName resName, in Variables.VariableName opA) : base(resName)
		{
			_operandAVarName = opA;
		}

		public override Variables.VariableTable Evaluate(Variables.VariableTable varTable)
		{
			/*if (!Check(varTable, _resultVarName))
			{
				throw new UndefinedVariable(_resultVarName);
			}*/
			if (!Check(varTable, _operandAVarName))
			{
				throw new UndefinedVariable(_operandAVarName);
			}
			if(Check(varTable, _resultVarName) && varTable[_resultVarName].Type != varTable[_operandAVarName].Type)
			{
				throw new VariableTypeMismatchException(_resultVarName);
			}

			varTable[_resultVarName] = varTable[_operandAVarName];
			return varTable;
		}
	}

	public class StatementAssignment : Assignment
	{
		private readonly Statement _statement;

		public StatementAssignment(in Variables.VariableName resName, in Statement s) : base(resName)
		{
			_statement = s;
		}

		public override Variables.VariableTable Evaluate(Variables.VariableTable varTable)
		{
			/*if (!Check(varTable, _resultVarName))
			{
				throw new UndefinedVariable(_resultVarName);
			}*/
			Variables.Variable resVar = _statement.Evaluate(varTable);
			if (Check(varTable, _resultVarName) && varTable[_resultVarName].Type != resVar.Type)
			{
				throw new VariableTypeMismatchException(_resultVarName);
			}

			varTable[_resultVarName] = resVar;
			return varTable;
		}
	}
}
