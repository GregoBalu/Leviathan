using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Model.Map.Segments
{


	public class MoveOption
	{
		public Conditions Conditions { get; set; }

		public string Content { get; set; }

		public Int64 ToId { get; set; }

		public MoveOption(String c, Int32 i, Conditions conds)
		{
			Content = c;
			ToId = i;
			Conditions = conds;
		}

	}
}
