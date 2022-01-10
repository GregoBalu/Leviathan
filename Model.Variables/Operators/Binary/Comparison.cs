using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{

	public class Equality : BinaryOperator
	{
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float, Variables.VariableType.Boolean, Variables.VariableType.String };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float, Variables.VariableType.Boolean, Variables.VariableType.String };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Boolean && rhs.Type == Variables.VariableType.Boolean)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.String && rhs.Type == Variables.VariableType.String)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

		public override Variables.Variable Execute(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return Execute((Variables.Integer)lhs, (Variables.Integer)rhs);
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return Execute((Variables.Float)lhs, (Variables.Float)rhs);
			}
			else if (lhs.Type == Variables.VariableType.Boolean && rhs.Type == Variables.VariableType.Boolean)
			{
				return Execute((Variables.Boolean)lhs, (Variables.Boolean)rhs);
			}
			else if (lhs.Type == Variables.VariableType.String && rhs.Type == Variables.VariableType.String)
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
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float, Variables.VariableType.Boolean, Variables.VariableType.String };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float, Variables.VariableType.Boolean, Variables.VariableType.String };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Boolean && rhs.Type == Variables.VariableType.Boolean)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.String && rhs.Type == Variables.VariableType.String)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

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
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

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
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

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
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

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
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

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
