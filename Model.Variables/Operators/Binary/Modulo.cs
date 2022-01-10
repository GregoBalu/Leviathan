﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{
	public class Modulo : BinaryOperator
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
			return new HashSet<Variables.VariableType> { Variables.VariableType.Integer, Variables.VariableType.Float };
		}
		public override HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs)
		{
			if (lhs.Type == Variables.VariableType.Integer && rhs.Type == Variables.VariableType.Integer)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Integer };
			}
			else if (lhs.Type == Variables.VariableType.Float && rhs.Type == Variables.VariableType.Float)
			{
				return new HashSet<Variables.VariableType> { Variables.VariableType.Float };
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

			throw new InvalidOperationException("Invalid % operation for variables " + lhs.ToString() + " % " + rhs.ToString());
		}
		public Variables.Integer Execute(Variables.Integer first, Variables.Integer second)
		{
			return first % second;
		}

		public Variables.Float Execute(Variables.Float first, Variables.Float second)
		{
			return first % second;
		}

	}

}
