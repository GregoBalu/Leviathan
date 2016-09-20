using System;

namespace Leviathan.ViewModel.Exceptions
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
