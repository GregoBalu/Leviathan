using System;
using System.Collections.Generic;

using Leviathan.Model.CharacterRelated.SkillRelated;

namespace Leviathan.Model.CharacterRelated
{
    public class Skills
    {
        public Int32 UnSpentPoints { get; set; }

        public SkillTree SkillTree { get; set; }

        public Skills(Profession pr)
        {
            UnSpentPoints = 0;

            SkillTree = ProfessionManager.getSkillTree(pr);
        }
    }
}
