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

		public Boolean(bool val) : base()
		{
			Value = val;
		}

		public static implicit operator Boolean(bool val)
		{
			return new Boolean(val);
		}

		public static implicit operator bool(Boolean b) => b.Value;

		public override bool Equals(object? obj) => this.Equals(obj as Boolean);
		public bool Equals(Boolean? other)
		{
			if (other is null)
				return false;

			if (Object.ReferenceEquals(this, other))
				return true;

			if (this.GetType() != other.GetType())
			{
				return false;
			}

			return Value.Equals(other.Value);
		}

		public override int GetHashCode() => Value.GetHashCode();

		public override string ToString() => Value.ToString();
	}
}
