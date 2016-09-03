using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated.StatRelated
{
    public static class StatManager
    {
        public static Int32 HealthMod(Race r, Profession prof)
        {
            Int32 result = 0;

            result += RaceManager.getLevelUps(r).Health.Max;

            result += ProfessionManager.getLevelUps(prof).Health.Max;

            return result;
        }

        public static Int32 ManaMod(Race r, Profession prof)
        {
            Int32 result = 0;

            result += RaceManager.getLevelUps(r).Mana.Max;

            result += ProfessionManager.getLevelUps(prof).Mana.Max;

            return result;
        }

        public static Int32 AttackMod(Race r, Profession prof)
        {
            Int32 result = 0;

            result += RaceManager.getLevelUps(r).Attack.Max;

            result += ProfessionManager.getLevelUps(prof).Attack.Max;

            return result;
        }

        public static Int32 DefenseMod(Race r, Profession prof)
        {
            Int32 result = 0;

            result += RaceManager.getLevelUps(r).Defense.Max;

            result += ProfessionManager.getLevelUps(prof).Defense.Max;

            return result;
        }

        public static Int32 SpeedMod(Race r, Profession prof)
        {
            Int32 result = 0;

            result += RaceManager.getLevelUps(r).Speed;

            result += ProfessionManager.getLevelUps(prof).Speed;

            return result;
        }

        public static Stats Default(Race r, Profession prof)
        {
            Stats result = new Stats();

            result = RaceManager.getStart(r);

            result += ProfessionManager.getStart(prof);

            return result;
        }

    }
}
