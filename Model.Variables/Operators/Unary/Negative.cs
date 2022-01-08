namespace Model.Variables.Operators
{
	public class Negative : UnaryOperator
	{
		public override Variables.Variable Execute(in Variables.Variable val)
		{
			if (val is Variables.Integer)
				return Execute((Variables.Integer)val);
			if (val is Variables.Float)
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
