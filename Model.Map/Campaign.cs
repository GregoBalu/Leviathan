using Model.Map.Segments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
	public class Campaign
	{
		public string Id { get; set; }
		public List<Segment> Segments { get; set; }

		private Int32 _current;
		[Newtonsoft.Json.JsonIgnore]
		public Segment Current
		{
			get
			{
				return Segments[_current];
			}
		}

		public Campaign()
		{
			Id = "";
			Segments = new List<Segment>();
			_current = 0;
		}

		public bool CanGoTo(Int32 id, Variables.Variables.VariableTable varTable)
		{
			if (id > 0 && id < Segments.Count)
			{
				return Current.Options.Any(opt => (opt.ToId == id) && opt.Condition.Check(varTable));
			}
			return false;
		}

		public bool MoveTo(Int32 id, ref Character.Character c)
		{
			if (CanGoTo(id, c.VarTable))
			{
				if (Current.IsFirst)
				{
					Current.OnFirstExit(ref c);
				}
				else
				{
					Current.OnExit(ref c);
				}

				_current = id;

				if (Current.IsFirst)
				{
					Current.OnFirstEnter(ref c);
				}
				else
				{
					Current.OnEnter(ref c);
				}
			}
			return false;
		}
	}
}
