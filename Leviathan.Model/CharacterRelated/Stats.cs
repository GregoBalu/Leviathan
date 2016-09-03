using System;
using Leviathan.Model.CharacterRelated.StatRelated;
using Leviathan.Model.Exceptions;

namespace Leviathan.Model.CharacterRelated
{
    public class Stats 
    {
        #region Properties

        public Health Health { get; set; }

        public Mana Mana { get; set; }

        public Experience Experience { get; set; }

        public Range Attack { get; set; }

        public Range Defense { get; set; }

        public Int32 Speed { get; set; }

        #endregion

        #region Contructors

        public Stats()
        {
            Health = new Health(1,1);
            Mana = new Mana(0,0);
            Experience = new Experience(0,100,1);
            Attack = new Range(0,0);
            Defense = new Range(0,0);
            Speed = 0;
        }

        #endregion

        #region Public Methods

        public Int32 Damage(Int32 val)
        {
            Int32 amount = val;
            amount -= Defense.Value;
            if (amount < 0)
                amount = 0;

            Health.Damage(amount);
            return amount;
        }

        public static Stats operator+(Stats a, Stats b)
        {
            Stats result = new Stats();
            result.Health = a.Health + b.Health;
            result.Mana = a.Mana + b.Mana;
            result.Experience = a.Experience + b.Experience;
            result.Attack = a.Attack + b.Attack;
            result.Defense = a.Defense + b.Defense;
            result.Speed = a.Speed + b.Speed;

            return result;
        }

        public override String ToString()
        {
            String result = "";

            if(Health.Current != 0 || Health.Max != 0)
                result += "Health: " + Health.ToString() + Environment.NewLine;
            if (Mana.Current != 0 || Mana.Max != 0)
                result += "Mana: " + Mana.ToString() + Environment.NewLine;
            if (Experience.Current != 0 || Experience.Level != 0)
                result += "Experience: " + Experience.ToString() + Environment.NewLine;
            if (Attack.Min != 0 || Attack.Max != 0)
                result += "Attack: " + Attack.ToString() + Environment.NewLine;
            if (Defense.Min != 0 || Defense.Max != 0)
                result += "Defense: " + Defense.ToString() + Environment.NewLine;
            if(Speed != 0)
                result += "Speed: " + Speed.ToString() + Environment.NewLine;

            result = result.TrimEnd('\r','\n');

            return result;
        }

        #endregion

        #region Static Methods

        public static Stats Null
        {
            get
            {
                Stats result = new Stats();

                result.Health = (Health)0;
                result.Mana = (Mana)0;
                result.Experience = (Experience)0;
                result.Attack = (Range)0;
                result.Defense = (Range)0;
                result.Speed = 0;

                return result;
            }
        }

        #endregion

    }
}
