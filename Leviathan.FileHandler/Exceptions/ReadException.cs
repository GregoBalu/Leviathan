using System;

namespace Leviathan.FileHandler.Exceptions
{
    [Serializable]
    public class ReadException : Exception
    {

        public ReadException() : base()
        { }

        public ReadException(String msg) : base(msg)
        { }
    }
}
