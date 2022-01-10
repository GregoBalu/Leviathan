using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{
	public  class String : Variable
	{
		private string Value { get; set; }

		public String(string val) : base(VariableType.String)
		{
			Value = val;
		}

		public static implicit operator String(string val)
		{
			return new String(val);
		}

		public static String operator +(String first, String second)
		{
			return first.Value + second.Value;
		}

		public override bool Equals(Variable rhs)
		{
			if (Type != rhs.Type)
			{
				return false;
			}

			if (Object.ReferenceEquals(this, rhs))
				return true;

			return Equals((String)rhs);
		}
		public bool Equals(String other)
		{
			return Value.Equals(other.Value);
		}

		public override int GetHashCode() => Value.GetHashCode();

		public override string ToString() => Value.ToString();

	}
}
