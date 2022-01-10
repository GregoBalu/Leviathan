using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{
	public class And : BinaryOperator
	{
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Boolean && rhs.Type == Variables.VariableType.Boolean)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

		public override Variables.Variable Execute(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Boolean && rhs.Type == Variables.VariableType.Boolean)
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
		public override HashSet<Variables.VariableType> SupportedLeftArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedRightArgumentTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes()
		{
			return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Boolean && rhs.Type == Variables.VariableType.Boolean)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Boolean };
			}

			return new HashSet<Variables.VariableType> { };
		}

		public override Variables.Variable Execute(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Boolean && rhs.Type == Variables.VariableType.Boolean)
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
