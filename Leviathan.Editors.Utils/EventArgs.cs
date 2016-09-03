using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Editors.Utils
{
    public class IdEventArgs : EventArgs
    {
        public Int32 Id { get; set; }

        public IdEventArgs(Int32 id_) : base()
        {
            Id = id_;
        }
    }

    public class StringEventArgs : EventArgs
    {
        public String String { get; set; }

        public StringEventArgs(String str) : base()
        {
            String = str;
        }
    }
}
