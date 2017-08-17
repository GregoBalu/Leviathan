using System;

namespace Leviathan.Model.CharacterRelated.SkillRelated
{
    public class Skill
    {
        public Boolean IsUnlocked
        { get; set; }

        public Int32 LevelRequired { get; set; }

        public Int32 AdditionalAttack { get; set; }

        public Int32 AdditionalDefense { get; set; }

        public Int32 AdditionalSpeed { get; set; }

        public Int32 AdditionalHealth { get; set; }

        public Int32 Heal { get; set; }

        public Int32 AdditionalMana { get; set; }

        public Int32 Recover { get; set; }

        public Int32 Range { get; set; }

        public String UseMessage { get; set; }

        public String ToolTip { get; set; }

        public String ImageName { get; set; }

        public String DisplayName { get; set; }

        public Int32 Duration { get; set; }

        public Int32 IsOnCooldown 
        { get; set; }

        public Int32 Cooldown { get; set; }

        public Int32 ManaCost { get; set; }

        #region Ctors

        public Skill()
        {
            DisplayName = "NEW";
        }

        public Skill(String dn)
        {
            DisplayName = dn;
        }

        #endregion

        #region Equality

        public static Boolean operator==(Skill a, Skill b)
        {
            if ((a as Object) == null ||(b as Object) == null)
                return false;

            return a.DisplayName == b.DisplayName;
        }

        public static Boolean operator!=(Skill a, Skill b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return this == (obj as Skill);
        }

        public override int GetHashCode()
        {
            return DisplayName.GetHashCode();
        }

        #endregion

    }
}
