using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.Exceptions
{
    [Serializable]
    public class MissingResourceException : Exception
    {
        public MissingResourceException(String msg) : base(msg)
        {

        }
    }
}
