using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{
	public  class Integer : Variable
	{
		private Int64 Value { get; set; }

		public Integer(Int64 val) : base()
		{
			Value = val;
		}

		public static implicit operator Integer(Int64 val)
		{
			return new Integer(val);
		}

		public static Integer operator-(Integer lhs)
		{
			return new Integer(-lhs.Value);
		}

		public static Integer operator+(Integer first, Integer second)
		{
			return first.Value + second.Value;
		}

		public static Integer operator -(Integer first, Integer second)
		{
			return first.Value - second.Value;
		}

		public static Integer operator *(Integer first, Integer second)
		{
			return first.Value * second.Value;
		}

		public static Integer operator /(Integer first, Integer second)
		{
			return first.Value / second.Value;
		}

		public static Integer operator %(Integer first, Integer second)
		{
			return first.Value % second.Value;
		}

		public static Boolean operator <(Integer first, Integer second)
		{
			return first.Value < second.Value;
		}

		public static Boolean operator >(Integer first, Integer second)
		{
			return first.Value > second.Value;
		}

		public static Boolean operator <=(Integer first, Integer second)
		{
			return first.Value <= second.Value;
		}

		public static Boolean operator >=(Integer first, Integer second)
		{
			return first.Value >= second.Value;
		}

		public override bool Equals(object? obj) => this.Equals(obj as Integer);
		public bool Equals(Integer? other)
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
