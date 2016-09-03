using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leviathan.Model.CharacterRelated.StatRelated
{
    public class Experience : BaseBar
    {
        public Int32 Level { get; set; }

        public Int32 LevelUps { get; set; }

        #region Events

        public event EventHandler LeveledUpEvent;
        private void OnLeveledUp()
        {
            if (LeveledUpEvent != null)
                LeveledUpEvent(this, EventArgs.Empty);
        }

        #endregion

        public Experience(Int32 value, Int32 max, Int32 lev) : base(value, max)
        {
            Level = lev;
            LevelUps = 0;
        }

        public void Gain(Int32 value)
        {
            _current = _current + value;
            if (_current > _max)
                LevelUp();
        }

        private void LevelUp()
        {
            while (_current > _max)
            {
                Int32 half = _max / 2;
                _current = _current - _max;
                _max = _max + half;
                ++LevelUps;
                ++Level;
            }
            OnLeveledUp();
        }

        public static Experience operator +(Experience a, Experience b)
        {
            Experience result = new Experience(a.Current + b.Current, Math.Min(a.Max, b.Max), a.Level + b.Level);
            result.LevelUp();
            return result;
        }

        public static explicit operator Experience(Int32 value)
        {
            return new Experience(value, value, value);
        }

        public override string ToString()
        {
            return Current.ToString() + "/" + Max.ToString() + ", lvl" + Level.ToString();
        }
    }
}
