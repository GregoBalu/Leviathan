namespace Model.Variables.Operators
{
	public class Negate : UnaryOperator
	{
		public override HashSet<Variables.VariableType> SupportedArgumentTypes()
		{
			return new HashSet<Variables.VariableType>() { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType>() { Variables.VariableType.Boolean };
		}

		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable arg)
		{
			if (arg.Type == Variables.VariableType.Boolean)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

		public override Variables.Variable Execute(in Variables.Variable val)
		{
			if (val is Variables.Boolean)
				return Execute((Variables.Boolean)val);

			throw new InvalidOperationException("Invalid ! operation for variable " + val.ToString());
		}

		public Variables.Boolean Execute(Variables.Boolean val)
		{
			return !val;
		}
	}
}
