using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Variables.Operators
{
	public abstract class Operator
	{
		public abstract HashSet<Variables.VariableType> SupportedReturnTypes();

	}
}
