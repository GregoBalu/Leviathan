using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Editors.Utils
{
    public class IdEventArgs : EventArgs
    {
        public Int32 Id { get; private set; }

        public IdEventArgs(Int32 id_) : base()
        {
            Id = id_;
        }
    }

    public class StringEventArgs : EventArgs
    {
        public String String { get; private set; }

        public StringEventArgs(String str) : base()
        {
            String = str;
        }
    }
    public class SkillEventArgs : EventArgs
    {
        public Model.CharacterRelated.SkillRelated.Skill Skill { get; private set; }

        public SkillEventArgs(Model.CharacterRelated.SkillRelated.Skill sk) : base()
        {
            Skill = sk;
        }
    }
}
