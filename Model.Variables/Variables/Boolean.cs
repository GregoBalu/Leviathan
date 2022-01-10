using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{
	public  class Boolean : Variable
	{
		private bool Value { get; set; }

		public Boolean(bool val) : base(VariableType.Boolean)
		{
			Value = val;
		}

		public static implicit operator Boolean(bool val)
		{
			return new Boolean(val);
		}

		public static implicit operator bool(Boolean b) => b.Value;

		public override bool Equals(Variable rhs)
		{
			if (Type != rhs.Type)
			{
				return false;
			}

			if (Object.ReferenceEquals(this, rhs))
				return true;

			return Equals((Boolean)rhs);
		}
		public bool Equals(Boolean other)
		{
			return Value.Equals(other.Value);
		}

		public override int GetHashCode() => Value.GetHashCode();

		public override string ToString() => Value.ToString();
	}
}
