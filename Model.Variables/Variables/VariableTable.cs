using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{
	public struct VariableName
	{
		public string Scope;
		public string Name;

		public VariableName(in string s, in string n)
		{
			Scope = s;
			Name = n;
		}

		public override string ToString()
		{
			return Scope + "@" + Name;
		}
	}

	public class VariableTable : Dictionary<VariableName, Variables.Variable >
	{
		public static VariableTable operator+(VariableTable lhs, VariableTable rhs)
		{
			VariableTable result = lhs;

			foreach(VariableName key in rhs.Keys)
			{
				result.Add(key, rhs[key]);
			}

			return result;
		}

	}
}
