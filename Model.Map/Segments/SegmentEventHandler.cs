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
		public enum HandlerType { Script, GiveItem };
		public HandlerType Type { get; private set;}

		protected SegmentEventHandler(HandlerType t)
		{
			Type = t;
		}

		public abstract void Notify(ref Character.Character c);
	}
}
