using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map.Segments.EventHandlers
{
	public class ScriptEventHandler : SegmentEventHandler
	{
		public List<Variables.Statement.Assignment> Assignments { get; set; }

		public ScriptEventHandler() : base(HandlerType.Script)
		{
			Assignments = new List<Variables.Statement.Assignment>();
		}

		public override void Notify(ref Character.Character c)
		{
			foreach (Variables.Statement.Assignment assig in Assignments)
			{
				c.VarTable = assig.Evaluate(c.VarTable);
			}
		}
	}
}
