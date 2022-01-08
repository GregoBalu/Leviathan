
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Character
{
	public class Character
	{
		public Variables.Variables.VariableTable VarTable { get; set; }

		public Character()
		{
			VarTable = new Variables.Variables.VariableTable();
		}
	}
}
