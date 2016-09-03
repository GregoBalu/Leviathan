using System;
using System.Collections.Generic;

using Leviathan.Model.Exceptions;

namespace Leviathan.Model.MapRelated
{
    
    public class Segment
    {
        //public Int32 Id { get; set; }

        public String ImageName { get; set; }

        public String Content { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public Boolean IsSpecial
        {
            get
            {
                return _special.Type != Specials.SpecialType.None;
            }
        }

        private Special _special;
        public Special Special 
        { 
            get
            {
                return _special;
            }
            set
            {
                _special = value;
                if(_special.Type != Specials.SpecialType.None)
                    Content = "[SPECIAL:" + _special.Type.ToString() + "]";
            }
        }

        public List<MoveOption> Options { get; set; }

        public Segment()
        {
            Content = "";
            Special = new MapRelated.Special();
            Options = new List<MoveOption>();
        }

        public Segment(String img, String cont, Special sp, List<MoveOption> opt)
        {
            //Id = id;
            ImageName = img;
            Content = cont;
            Special = sp;
            Options = opt;
        }

    }
}
