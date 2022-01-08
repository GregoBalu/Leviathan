using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{
	public abstract class BinaryOperator : Operator
	{

		public abstract Variables.Variable Execute(in Variables.Variable lhs, in Variables.Variable rhs);
	}
}
