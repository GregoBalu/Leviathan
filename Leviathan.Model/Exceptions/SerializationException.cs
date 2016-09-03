using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.Exceptions
{
    [Serializable]
    public class SerializationException : Exception
    {

        public SerializationException(String delim) :
            base("Formatter String(" + delim + ") found in inner String!")
        {
            
        }
    }
}
