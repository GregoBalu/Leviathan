using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated.SkillRelated.Skills.Warrior
{
    public class Skill2 : Skill
    {

        public override int AdditionalAttack()
        {
            return Convert.ToInt32(WarriorResources.Skill2_PlusAttack);
        }

        public override int AdditionalDefense()
        {
            return Convert.ToInt32(WarriorResources.Skill2_PlusDefense);
        }

        public override int AdditionalSpeed()
        {
            return 0;
        }

        public override int AdditionalHealth()
        {
            return 0;
        }

        public override int Heal()
        {
            return 0;
        }

        public override int AdditionalMana()
        {
            return 0;
        }

        public override int Recover()
        {
            return 0;
        }

        public override string DisplayName()
        {
            return WarriorResources.Skill2_Name;
        }

        public override int IsOnCooldown { get; set; }

        public override int Cooldown()
        {
            return Convert.ToInt32(WarriorResources.Skill2_Cooldown);
        }

        public override int ManaCost()
        {
            return Convert.ToInt32(WarriorResources.Skill2_ManaCost);
        }

        public override int Duration()
        {
            return Convert.ToInt32(WarriorResources.Skill2_Duration);
        }

        public override string ToolTip()
        {
            return WarriorResources.Skill2_ToolTip.Replace("\\r\\n", "\r\n"); ;
        }

        public override string UseMessage()
        {
            String[] temp = WarriorResources.Skill2_UseMessage.Split(';');
            Random r = new Random(DateTime.Now.Millisecond);
            return temp[r.Next(0, temp.Length - 1)];
        }

        public override string ImageName()
        {
            return WarriorResources.Skill2_ImageName;
        }

        public override int Range()
        {
            return Convert.ToInt32(WarriorResources.Skill2_Range);
        }

        public override int LevelRequired()
        {
            return Convert.ToInt32(WarriorResources.Skill2_LevelRequired);
        }
    }
}
