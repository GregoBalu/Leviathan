using System;

namespace Leviathan.Model.CharacterRelated
{
    public class Profession
    {
        public String ProfessionName { get; set; }

        public Profession(String val)
        {
            ProfessionName = val;
        }

        public override string ToString()
        {
            return ProfessionName;
        }
    }
}
