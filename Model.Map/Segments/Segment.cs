using Model.Character;
using Model.Map.Segments;
using Model.Variables.Variables;
using System;
using System.Collections.Generic;


namespace Model.Map.Segments
{
	
	public class Segment
	{
		public Int32 Id { get; set; }

		public bool IsFirst { get; set; }

		#region Events

		private List<SegmentEventHandler> OnEnterList;
		private List<SegmentEventHandler> OnFirstEnterList;
		private List<SegmentEventHandler> OnExitList;
		private List<SegmentEventHandler> OnFirstExitList;

		public void OnEnter(ref Character.Character c)
		{
			foreach (SegmentEventHandler evh in OnEnterList)
			{
				evh.Notify(ref c);
			}
		}
		public void OnFirstEnter(ref Character.Character c)
		{
			foreach (SegmentEventHandler evh in OnFirstEnterList)
			{
				evh.Notify(ref c);
			}
		}
		public void OnExit(ref Character.Character c)
		{
			IsFirst = false;
			foreach (SegmentEventHandler evh in OnExitList)
			{
				evh.Notify(ref c);
			}
		}
		public void OnFirstExit(ref Character.Character c)
		{
			IsFirst = false;
			foreach (SegmentEventHandler evh in OnFirstExitList)
			{
				evh.Notify(ref c);
			}
		}

		#endregion Events

		//Base

		public string ImagePath { get; set; }

		public string Content { get; set; }

		public List<MoveOption> Options { get; set; }

		public Segment()
		{
			Id = -1;
			IsFirst = true;
			ImagePath = "";
			Content = "";
			Options = new List<MoveOption>();

			OnEnterList = new List<SegmentEventHandler>();
			OnFirstEnterList = new List<SegmentEventHandler>();
			OnExitList = new List<SegmentEventHandler>();
			OnFirstExitList = new List<SegmentEventHandler>();
		}

		public Segment(Int32 id, bool isf, string img, string cont, List<MoveOption> opt) : this()
		{
			Id = id;
			IsFirst = isf;
			ImagePath = img;
			Content = cont;
			Options = opt;

			
		}

	}
}
