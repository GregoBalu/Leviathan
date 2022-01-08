using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{
	public class And : BinaryOperator
	{
		public override Variables.Variable Execute(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs is Variables.Boolean && rhs is Variables.Boolean)
			{
				return Execute((Variables.Boolean)lhs, (Variables.Boolean)rhs);
			}

			throw new InvalidOperationException("Invalid && operation for variables " + lhs.ToString() + " && " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Boolean first, Variables.Boolean second)
		{
			return first && second;
		}

	}

	public class Or : BinaryOperator
	{
		public override Variables.Variable Execute(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs is Variables.Boolean && rhs is Variables.Boolean)
			{
				return Execute((Variables.Boolean)lhs, (Variables.Boolean)rhs);
			}

			throw new InvalidOperationException("Invalid || operation for variables " + lhs.ToString() + " || " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Boolean first, Variables.Boolean second)
		{
			return first || second;
		}

	}


}
