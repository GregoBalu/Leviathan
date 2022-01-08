namespace Model.Map.Segments
{
	public class Condition
	{
		private Variables.Variables.VariableName _variableName;
		private Variables.Operators.BinaryOperator _op;
		private Variables.Variables.Variable _val;

		public Condition(Variables.Variables.VariableName vN, Variables.Operators.BinaryOperator bop, Variables.Variables.Variable val)
		{
			_variableName = vN;
			_op = bop;
			_val = val;
		}

		public bool Check(Variables.Variables.VariableTable varTable)
		{
			if (varTable.ContainsKey(_variableName))
			{
				Variables.Variables.Variable result = _op.Execute(varTable[_variableName], _val);
				if (result is Variables.Variables.Boolean)
				{
					return (Variables.Variables.Boolean)result;
				}
			}

			return false;
		}
	}

	public class Conditions
	{
		private List<Condition> _checks;

		public Conditions(List<Condition> conds)
		{
			_checks = conds;
		}

		public bool Check(Variables.Variables.VariableTable varTable)
		{
			foreach (Condition cond in _checks)
			{
				if (!cond.Check(varTable))
					return false;
			}
			return true;
		}
	}
}
