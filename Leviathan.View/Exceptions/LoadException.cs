using System;

namespace Leviathan.View.Exceptions
{
    [Serializable]
    public class LoadException : Exception
    {

        public LoadException() : base()
        { }

        public LoadException(String msg) : base(msg)
        { }
    }
}
