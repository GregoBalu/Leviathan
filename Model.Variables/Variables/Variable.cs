using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Variables
{

	public abstract class Variable
	{

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
			// Equals handles case of null on right side.
			return lhs.Equals(rhs);
		}

		public static bool operator !=(Variable lhs, Variable rhs) => !(lhs == rhs);

		public abstract override bool Equals(object? obj);// => this.Equals(obj as Variable);

		public abstract override int GetHashCode();// => Value().GetHashCode();

		public abstract override string ToString();

	}

}
