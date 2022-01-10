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

		public abstract HashSet<Variables.VariableType> SupportedLeftArgumentTypes();
		public abstract HashSet<Variables.VariableType> SupportedRightArgumentTypes();
		public abstract override HashSet<Variables.VariableType> SupportedReturnTypes();

		public bool SupportsLeftArgument(in Variables.Variable arg) => SupportedLeftArgumentTypes().Contains(arg.Type);
		public bool SupportsRightArgument(in Variables.Variable arg) => SupportedRightArgumentTypes().Contains(arg.Type);
		public abstract HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable lhs, in Variables.Variable rhs);
		public bool SupportsArguments(in Variables.Variable lhs, in Variables.Variable rhs) => SupportedReturnTypes(lhs, rhs).Count > 0;
	}
}
