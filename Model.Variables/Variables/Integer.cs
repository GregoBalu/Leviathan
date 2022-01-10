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

		public Integer(Int64 val) : base(VariableType.Integer)
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

		public override bool Equals(Variable rhs)
		{
			if (Type != rhs.Type)
			{
				return false;
			}

			if (Object.ReferenceEquals(this, rhs))
				return true;

			return Equals((Integer)rhs);
		}

		public bool Equals(Integer other)
		{
			return Value.Equals(other.Value);
		}

		public override int GetHashCode() => Value.GetHashCode();

		public override string ToString() => Value.ToString();
	}
}
