using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{
	public  class Float : Variable
	{
		private float Value { get; set; }

		public Float(float val) : base(VariableType.Float)
		{
			Value = val;
		}

		public static implicit operator Float(float val)
		{
			return new Float(val);
		}

		public static Float operator -(Float lhs)
		{
			return new Float(-lhs.Value);
		}

		public static Float operator +(Float first, Float second)
		{
			return first.Value + second.Value;
		}

		public static Float operator -(Float first, Float second)
		{
			return first.Value - second.Value;
		}

		public static Float operator *(Float first, Float second)
		{
			return first.Value * second.Value;
		}

		public static Float operator /(Float first, Float second)
		{
			return first.Value / second.Value;
		}

		public static Float operator %(Float first, Float second)
		{
			return first.Value % second.Value;
		}

		public static Boolean operator <(Float first, Float second)
		{
			return first.Value < second.Value;
		}

		public static Boolean operator >(Float first, Float second)
		{
			return first.Value > second.Value;
		}

		public static Boolean operator <=(Float first, Float second)
		{
			return first.Value <= second.Value;
		}

		public static Boolean operator >=(Float first, Float second)
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

			return Equals((Float)rhs);
		}
		public bool Equals(Float other)
		{
			return Value.Equals(other.Value);
		}

		public override int GetHashCode() => Value.GetHashCode();

		public override string ToString() => Value.ToString();
	}
}
