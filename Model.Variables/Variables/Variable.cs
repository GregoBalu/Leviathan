using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{
	public enum VariableType
	{
		Integer,
		Float,
		String,
		Boolean
	}

	public abstract class Variable
	{
		public VariableType Type { get; private set; }

		protected Variable(VariableType t)
		{
			Type = t;
		}

		public static bool operator ==(Variable lhs, Variable rhs)
		{
			if (lhs is null)
			{
				if (rhs is null)
				{
					return true;
				}

				// Only the left side is null.
				return false;
			}

			return lhs.Equals(rhs);
		}

		public static bool operator !=(Variable lhs, Variable rhs) => !(lhs == rhs);

		public override bool Equals(object? obj)
		{
			if (obj is Variable)
			{
				return Equals((Variable)obj);
			}
			return false;
		}

		public abstract bool Equals(Variable rhs);

		public abstract override int GetHashCode();// => Value().GetHashCode();

		public abstract override string ToString();

	}

}
