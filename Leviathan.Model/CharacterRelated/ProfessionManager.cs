using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated
{
    public static class ProfessionManager
    {
        public static Dictionary<String, ProfessionInfo> Professions { get; set; }

        public class ProfessionInfo
        {
            public Stats Start { get; set; }
            public Stats LevelUp { get; set; }
            public SkillRelated.SkillTree SkillTree { get; set; }

            public ProfessionInfo()
            {
                Start = new Stats();
                LevelUp = new Stats();
                SkillTree = new SkillRelated.SkillTree();
            }
        }

        private static void checkLoad()
        {
            if (Professions == null)
                loadProfessions();

            if (Professions.Count == 0)
                throw new Exceptions.MissingResourceException("No Professions file found!");
        }

        public static void loadProfessions()
        {
            Professions = FileHandler.FileHandler.Read<Dictionary<String, ProfessionInfo>>(
                FileHandler.FileHandler.ConfigFolder + "professions.levi",
                typeof(ProfessionManager));
        }

        public static void saveProfessions()
        {

            FileHandler.FileHandler.Write(
                FileHandler.FileHandler.ConfigFolder + "Professions.levi",
                Professions,
                typeof(ProfessionManager));
        }

        public static List<Profession> getProfessions()
        {
            checkLoad();

            return Professions.Keys.Select(x => new Profession(x)).ToList<Profession>();
        }

        public static Stats getStart(Profession prof)
        {
            checkLoad();

            if (!Professions.ContainsKey(prof.ProfessionName))
            {
                throw new Exceptions.MissingResourceException("Cannot find Profession: " + prof.ProfessionName + ".");
            }

            return Professions[prof.ProfessionName].Start;
        }

        public static Stats getLevelUps(Profession prof)
        {
            checkLoad();

            if (!Professions.ContainsKey(prof.ProfessionName))
            {
                throw new Exceptions.MissingResourceException("Cannot find Profession: " + prof.ProfessionName + ".");
            }

            return Professions[prof.ProfessionName].LevelUp;
        }

        public static Profession getDefault()
        {
            checkLoad();

            return new Profession(Professions.First().Key);
        }

        public static SkillRelated.SkillTree getSkillTree(Profession prof)
        {
            checkLoad();

            if (!Professions.ContainsKey(prof.ProfessionName))
            {
                throw new Exceptions.MissingResourceException("Cannot find Profession: " + prof.ProfessionName + ".");
            }

            return Professions[prof.ProfessionName].SkillTree;
        }

    }
}
