namespace Model.Variables.Operators
{
	public class Increment : UnaryOperator
	{
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
