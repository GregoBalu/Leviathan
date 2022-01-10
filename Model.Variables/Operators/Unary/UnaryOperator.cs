
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{
	public abstract class UnaryOperator : Operator
	{
		public abstract Variables.Variable Execute(in Variables.Variable val);

		public abstract HashSet<Variables.VariableType> SupportedArgumentTypes();
		public abstract override HashSet<Variables.VariableType> SupportedReturnTypes();

		public bool SupportsArgument(in Variables.Variable val) => SupportedArgumentTypes().Contains(val.Type);
		public abstract HashSet<Variables.VariableType> SupportedReturnTypes(in Variables.Variable val);

	}
}
