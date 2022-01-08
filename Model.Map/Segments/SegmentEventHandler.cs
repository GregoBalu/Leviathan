using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Character;

namespace Model.Map.Segments
{
	public abstract class SegmentEventHandler
	{
		public abstract void Notify(ref Character.Character c);
	}
}
