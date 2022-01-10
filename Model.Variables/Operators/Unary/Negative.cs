namespace Model.Variables.Operators
{
	public class Negative : UnaryOperator
	{
		public override HashSet<Variables.VariableType> SupportedArgumentTypes()
		{
			return new HashSet<Variables.VariableType>() { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType>() { Variables.VariableType.Integer, Variables.VariableType.Float };
		}

		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable arg)
		{
			if (arg.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Integer };
			}
			else if (arg.Type != Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Float };
			}

			return new HashSet<Variables.VariableType> { };
		}

		public override Variables.Variable Execute(in Variables.Variable val)
		{
			if (val.Type == Variables.VariableType.Integer)
				return Execute((Variables.Integer)val);
			if (val.Type == Variables.VariableType.Float)
				return Execute((Variables.Float)val);

			throw new InvalidOperationException("Invalid - operation for variable " + val.ToString());
		}

		public Variables.Integer Execute(Variables.Integer val)
		{
			return -val;
		}

		public Variables.Float Execute(Variables.Float val)
		{
			return -val;
		}
	}
}
