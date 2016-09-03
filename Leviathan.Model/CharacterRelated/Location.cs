using System;
using System.Collections.Generic;

using Leviathan.Model.MapRelated;

namespace Leviathan.Model.CharacterRelated
{
    public class Location
    {
        public Region Region { get; set; }

        public Int32 SubRegion { get; set; }

        public VariableTable History { get; set; }

        public Location()
        {
            History = new VariableTable();
        }

        public Location(Region r) : this()
        {
            Region = r;
        }

        public Location(Region r, Int32 sr) : this(r)
        {
            SubRegion = sr;
        }

        public Location(Region r, Int32 sr, VariableTable h) : this(r, sr)
        {
            History = h;
        }
    }
}
