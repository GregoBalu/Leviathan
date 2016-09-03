using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated.SkillRelated.Skills.Warrior
{
    public class Skill1 : Skill
    {

        public override int AdditionalAttack()
        {
            return Convert.ToInt32(WarriorResources.Skill1_PlusAttack);
        }

        public override int AdditionalDefense()
        {
            return 0;
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
            return WarriorResources.Skill1_Name;
        }

        public override int IsOnCooldown { get; set; }

        public override int Cooldown()
        {
            return Convert.ToInt32(WarriorResources.Skill1_Cooldown);
        }

        public override int ManaCost()
        {
            return Convert.ToInt32(WarriorResources.Skill1_ManaCost);
        }

        public override int Duration()
        {
            return Convert.ToInt32(WarriorResources.Skill1_Duration);
        }

        public override string ToolTip()
        {
            return WarriorResources.Skill1_ToolTip.Replace("\\r\\n", "\r\n");
        }

        public override string UseMessage()
        {
            String[] temp = WarriorResources.Skill1_UseMessage.Split(';');
            Random r = new Random(DateTime.Now.Millisecond);
            return temp[r.Next(0, temp.Length - 1)];
        }

        public override string ImageName()
        {
            return WarriorResources.Skill1_ImageName;
        }


        public override int Range()
        {
            return Convert.ToInt32(WarriorResources.Skill1_Range);
        }

        public override int LevelRequired()
        {
            return Convert.ToInt32(WarriorResources.Skill1_LevelRequired);
        }
    }
}
