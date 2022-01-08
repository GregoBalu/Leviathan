using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{
	public class Multiply : BinaryOperator
	{
		public override Variables.Variable Execute(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs is Variables.Integer && rhs is Variables.Integer)
			{
				return Execute((Variables.Integer)lhs, (Variables.Integer)rhs);
			}
			else if (lhs is Variables.Float && rhs is Variables.Float)
			{
				return Execute((Variables.Float)lhs, (Variables.Float)rhs);
			}

			throw new InvalidOperationException("Invalid * operation for variables " + lhs.ToString() + " * " + rhs.ToString());
		}

		public Variables.Integer Execute(Variables.Integer first, Variables.Integer second)
		{
			return first * second;
		}

		public Variables.Float Execute(Variables.Float first, Variables.Float second)
		{
			return first * second;
		}
	}

}
