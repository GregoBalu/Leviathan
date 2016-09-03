using System;

namespace Leviathan.Model.CharacterRelated.SkillRelated
{
    public abstract class Skill
    {
        public abstract Boolean IsUnlocked
        { get; set; }

        public abstract Int32 LevelRequired();

        public abstract Int32 AdditionalAttack();

        public abstract Int32 AdditionalDefense();

        public abstract Int32 AdditionalSpeed();

        public abstract Int32 AdditionalHealth();

        public abstract Int32 Heal();

        public abstract Int32 AdditionalMana();

        public abstract Int32 Recover();

        public abstract Int32 Range();

        public abstract String UseMessage();

        public abstract String ToolTip();

        public abstract String ImageName();

        public abstract String DisplayName();

        public abstract Int32 Duration();

        public abstract Int32 IsOnCooldown 
        { get; set; }

        public abstract Int32 Cooldown();

        public abstract Int32 ManaCost();

        #region Equality

        public static Boolean operator==(Skill a, Skill b)
        {
            return a.DisplayName() == b.DisplayName();
        }

        public static Boolean operator!=(Skill a, Skill b)
        {
            return a.DisplayName() != b.DisplayName();
        }

        public override bool Equals(object obj)
        {
            return this == (obj as Skill);
        }

        public override int GetHashCode()
        {
            return DisplayName().GetHashCode();
        }

        #endregion

    }
}
