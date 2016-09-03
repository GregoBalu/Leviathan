using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated.StatRelated
{
    public class Mana : BaseBar
    { 

        public Mana(Int32 value, Int32 max) : base(value, max)
        {

        }

        public void Consume(Int32 value)
        {
            _current = _current - value;
            if (_current < 0)
                _current = 0;
        }

        public void Regen(Int32 value)
        {
            _current = _current + value;
            if (_current > _max)
                _current = _max;
        }

        public static Mana operator +(Mana a, Mana b)
        {
            return new Mana(a.Max + b.Max, a.Max + b.Max);
        }

        public static explicit operator Mana(Int32 value)
        {
            return new Mana(value, value);
        }

    }
}
