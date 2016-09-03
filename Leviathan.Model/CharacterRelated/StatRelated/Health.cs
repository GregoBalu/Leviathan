using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated.StatRelated
{
    public class Health : BaseBar
    {

        public Health(Int32 value, Int32 max) : base(value, max)
        {

        }

        public void Damage(Int32 value)
        {
            _current = _current - value;
            if (_current < 0)
                _current = 0;
        }

        public void Heal(Int32 value)
        {
            _current = _current + value;
            if (_current > _max)
                _current = _max;
        }

        public static Health operator+(Health a, Health b)
        {
            return new Health(a.Max + b.Max, a.Max + b.Max);
        }

        public static explicit operator Health(Int32 value)
        {
            return new Health(value, value);
        }

    }
}
