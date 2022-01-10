using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Model.Map.Segments
{


	public class MoveOption
	{
		public Condition Condition { get; set; }

		public string Content { get; set; }

		public Int64 ToId { get; set; }

		public MoveOption(String c, Int32 i, Condition cond)
		{
			Content = c;
			ToId = i;
			Condition = cond;
		}

	}
}
