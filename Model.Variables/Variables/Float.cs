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

		public Float(float val) : base()
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

		public override bool Equals(object? obj) => this.Equals(obj as Float);
		public bool Equals(Float? other)
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
