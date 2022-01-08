using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{

	public class Equality : BinaryOperator
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
			else if (lhs is Variables.Boolean && rhs is Variables.Boolean)
			{
				return Execute((Variables.Boolean)lhs, (Variables.Boolean)rhs);
			}
			else if (lhs is Variables.String && rhs is Variables.String)
			{
				return Execute((Variables.String)lhs, (Variables.String)rhs);
			}

			throw new InvalidOperationException("Invalid == operation for variables " + lhs.ToString() + " == " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Integer first, Variables.Integer second)
		{
			return first == second;
		}

		public Variables.Boolean Execute(Variables.Float first, Variables.Float second)
		{
			return first == second;
		}
		public Variables.Boolean Execute(Variables.Boolean first, Variables.Boolean second)
		{
			return first == second;
		}

		public Variables.Boolean Execute(Variables.String first, Variables.String second)
		{
			return first == second;
		}
	}

	public class InEquality : BinaryOperator
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
			else if (lhs is Variables.Boolean && rhs is Variables.Boolean)
			{
				return Execute((Variables.Boolean)lhs, (Variables.Boolean)rhs);
			}
			else if (lhs is Variables.String && rhs is Variables.String)
			{
				return Execute((Variables.String)lhs, (Variables.String)rhs);
			}

			throw new InvalidOperationException("Invalid != operation for variables " + lhs.ToString() + " != " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Integer first, Variables.Integer second)
		{
			return first != second;
		}

		public Variables.Boolean Execute(Variables.Float first, Variables.Float second)
		{
			return first != second;
		}

		public Variables.Boolean Execute(Variables.Boolean first, Variables.Boolean second)
		{
			return first != second;
		}

		public Variables.Boolean Execute(Variables.String first, Variables.String second)
		{
			return first != second;
		}
	}

	// *******************

	public class Less : BinaryOperator
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

			throw new InvalidOperationException("Invalid < operation for variables " + lhs.ToString() + " < " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Integer first, Variables.Integer second)
		{
			return first < second;
		}

		public Variables.Boolean Execute(Variables.Float first, Variables.Float second)
		{
			return first < second;
		}

	}


	public class Greater : BinaryOperator
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

			throw new InvalidOperationException("Invalid > operation for variables " + lhs.ToString() + " > " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Integer first, Variables.Integer second)
		{
			return first > second;
		}

		public Variables.Boolean Execute(Variables.Float first, Variables.Float second)
		{
			return first > second;
		}

	}

	public class LessEq : BinaryOperator
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

			throw new InvalidOperationException("Invalid <= operation for variables " + lhs.ToString() + " <= " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Integer first, Variables.Integer second)
		{
			return first <= second;
		}

		public Variables.Boolean Execute(Variables.Float first, Variables.Float second)
		{
			return first <= second;
		}

	}

	public class GreaterEq : BinaryOperator
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

			throw new InvalidOperationException("Invalid >= operation for variables " + lhs.ToString() + " >= " + rhs.ToString());
		}

		public Variables.Boolean Execute(Variables.Integer first, Variables.Integer second)
		{
			return first >= second;
		}

		public Variables.Boolean Execute(Variables.Float first, Variables.Float second)
		{
			return first >= second;
		}

	}


}
