using System;


namespace Leviathan.Model.MapRelated
{
    
    public class Pair<F, S>
    {
        
        public F First { get; set; }

        public S Second { get; set; }

        public Pair()
        {

        }

        public Pair(F f, S s)
        {
            First = f;
            Second = s;
        }
    }
}
