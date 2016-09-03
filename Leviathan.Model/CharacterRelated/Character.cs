using System;
using System.Collections.Generic;

using Leviathan.Model.CharacterRelated.StatRelated;
using Leviathan.Model.Exceptions;

namespace Leviathan.Model.CharacterRelated
{
    public class Character
    {
        #region Properties

        public String Name { get; set; }

        public Race Race { get; set; }

        private Profession _class;
        public Profession Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
                Skills = new Skills(_class);
            }
        }

        public Stats BaseStats { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public Stats TotalStats 
        { 
            get
            {
                return BaseStats + Equipped.BonusStats;
            }
        }

        public Skills Skills { get; set; }

        public List<SkillRelated.Skill> ActiveEffects { get; set; }

        public Location Location { get; set; }

        public Inventory Inventory { get; set; }

        public Equipped Equipped { get; set; }

        #endregion

        #region Constructors

        public Character()
        {
            Race = RaceManager.getDefault(); ;
            Class = ProfessionManager.getDefault();
            Equipped = new CharacterRelated.Equipped();
            BaseStats = new Stats();
            BaseStats.Experience.LeveledUpEvent += new EventHandler(LevelUp);
            Location = new Location();
            Inventory = new CharacterRelated.Inventory();
            Name = "";
            ActiveEffects = new List<SkillRelated.Skill>();
        }

        #endregion

        #region Public Methods

        private void LevelUp(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < BaseStats.Experience.LevelUps; ++i)
            {
                BaseStats.Health.Increase(StatManager.HealthMod(Race, Class));
                BaseStats.Mana.Increase(StatManager.ManaMod(Race, Class));
                BaseStats.Attack += StatManager.AttackMod(Race, Class);
                BaseStats.Defense += StatManager.DefenseMod(Race, Class);
                BaseStats.Speed += StatManager.SpeedMod(Race, Class);
                Skills.UnSpentPoints += 1;
            }
            BaseStats.Experience.LevelUps = 0;
        }

        public SkillRelated.Skill ChooseSkill(Character enemy)
        {
            //AI
            //TODO
            throw new NotImplementedException();

            return null;
        }

        public override string ToString()
        {
            return Race.ToString() + " " + Class.ToString() + " (" + BaseStats.Experience.Level + ")";
        }

        #endregion
    }
}
