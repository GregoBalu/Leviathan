namespace Model.Variables.Operators
{
	public class Increment : UnaryOperator
	{
		public override HashSet<Variables.VariableType> SupportedArgumentTypes()
		{
			return new HashSet<Variables.VariableType>() { Variables.VariableType.Integer };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType>() { Variables.VariableType.Integer };
		}

		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable arg)
		{
			if (arg.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Integer };
			}

			return new HashSet<Variables.VariableType> { };
		}

		public override Variables.Variable Execute(in Variables.Variable val)
		{
			if (val is Variables.Integer)
				return Execute((Variables.Integer)val);

			throw new InvalidOperationException("Invalid ++ operation for variable " + val.ToString());
		}

		public Variables.Integer Execute(Variables.Integer val)
		{
			return val + 1;
		}
	}
}
