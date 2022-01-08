namespace Model.Variables.Operators
{
	public class Negate : UnaryOperator
	{
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
