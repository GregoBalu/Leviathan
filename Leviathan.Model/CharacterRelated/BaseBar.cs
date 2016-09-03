using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated
{
    public abstract class BaseBar
    {
        protected Int32 _current;
        protected Int32 _max;

        public Int32 Current
        {
            get
            {
                return _current;
            }
            set
            {
                _current = value;
            }
        }

        public Int32 Max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
            }
        }

        #region Constructors

        public BaseBar()
        {
            _current = 0;
            _max = 100;
        }

        public BaseBar(Int32 value)
        {
            _current = _max = value;
        }

        public BaseBar(Int32 value, Int32 max)
        {
            _current = value;
            _max = max;
        }

        #endregion

        public void Increase(Int32 value)
        {
            _max = _max + value;
        }

        public void Decrease(Int32 value)
        {
            _max = _max - value;
            if (_current > _max)
                _current = _max;
        }

        public override string ToString()
        {
            return Current.ToString() + "/" + Max.ToString();
        }
    }
}
