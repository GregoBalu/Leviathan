using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Leviathan.Model.Exceptions;

namespace Leviathan.Model.MapRelated
{

    public class MoveOption
    {
        public Condition Condition { get; set; }

        public String Content { get; set; }

        public Int32 ToId { get; set; }

        public MoveOption()
        {
            Condition = MapRelated.Condition.Nothing;
        }

        public MoveOption(String c, Int32 i, Condition cond = null)
        {
            Content = c;
            ToId = i;
            if (cond == null)
                Condition = MapRelated.Condition.Nothing;
            else
                Condition = cond;
        }

    }
}
