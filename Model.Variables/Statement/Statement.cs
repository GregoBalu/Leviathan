using Model.Variables.Variables;

namespace Model.Variables.Statement
{
	public class UndefinedVariable : Exception
	{
		public UndefinedVariable(VariableName varName) : 
			base("Variable " + varName.ToString() + " is undefined in this context")
		{

		}
	}

	public abstract class Statement
	{
		public abstract Variables.Variable Evaluate(VariableTable varTable);

		protected bool Check(VariableTable varTable, VariableName varName)
		{
			return varTable.ContainsKey(varName);
		}

	}

	public class UnaryStatement : Statement
	{
		private readonly Operators.UnaryOperator _op;
		private readonly Variables.VariableName _operandA;


		public UnaryStatement(in Operators.UnaryOperator op, in Variables.VariableName opA) : base()
		{
			_op = op;
			_operandA = opA;
		}

		public override Variables.Variable Evaluate(VariableTable varTable)
		{
			if (!Check(varTable, (VariableName)_operandA))
			{
				throw new UndefinedVariable((VariableName)_operandA);
			}
			Variable opA = varTable[(VariableName)_operandA];
			if (!_op.SupportsArgument(opA))
			{
				throw new System.InvalidOperationException("Operation only supports arguments of type: " +
					_op.SupportedArgumentTypes().ToString());
			}

			return _op.Execute(opA);
		}
	}

	public class BinaryStatement : Statement
	{
		private readonly Operators.BinaryOperator _op;
		private readonly Variables.VariableName _operandA;
		private readonly Variables.VariableName _operandB;


		public BinaryStatement(in Operators.BinaryOperator op, in Variables.VariableName opA, in Variables.VariableName opB) : base()
		{
			_op = op;
			_operandA = opA;
			_operandB = opB;
		}

		public HashSet<VariableType> ReturnType(VariableTable varTable)// => _op.SupportedReturnTypes(_operandA, _operandB);
		{
			if (!Check(varTable, _operandA))
			{
				throw new UndefinedVariable(_operandA);
			}
			if (!Check(varTable, _operandB))
			{
				throw new UndefinedVariable(_operandB);
			}

			return _op.SupportedReturnTypes(varTable[_operandA], varTable[_operandB]);
		}

		public override Variables.Variable Evaluate(VariableTable varTable)
		{
			if (!Check(varTable, _operandA))
			{
				throw new UndefinedVariable(_operandA);
			}
			if (!Check(varTable, _operandB))
			{
				throw new UndefinedVariable(_operandB);
			}
			Variable opA = varTable[_operandA];
			Variable opB = varTable[_operandB];
			if (!_op.SupportsArguments(opA, opB))
			{
				throw new System.InvalidOperationException("Operation only supports arguments of type: " +
					_op.SupportedLeftArgumentTypes().Union(_op.SupportedRightArgumentTypes()).ToString());
			}
			return _op.Execute(opA, opB);
		}
	}

	public class TemporaryVariable
	{
		public VariableName Name { get; private set; }

		public TemporaryVariable(ref VariableTable varTable, Variable var)
		{
			Name = GenerateName();
			varTable[Name] = var;
		}

		public static implicit operator VariableName(TemporaryVariable tmpVar)
		{
			return tmpVar.Name;
		}

		private VariableName GenerateName()
		{
			return new VariableName("tmp", Guid.NewGuid().ToString());
		}
	}

}
