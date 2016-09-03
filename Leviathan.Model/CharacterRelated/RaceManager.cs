using System;
using System.Collections.Generic;
using System.Linq;

namespace Leviathan.Model.CharacterRelated
{

    public static class RaceManager
    {
        public static Dictionary<String, RaceInfo> Races { get; set; }

        public class RaceInfo
        {
            public Stats Start { get; set; }
            public Stats LevelUp { get; set; }
            public List<String> StartZones { get; set; }

            public RaceInfo() 
            {
                Start = new Stats();
                LevelUp = new Stats();
                StartZones = new List<string>();
            }
        }

        private static void checkLoad()
        {
            if (Races == null)
                loadRaces();

            if (Races.Count == 0)
                throw new Exceptions.MissingResourceException("No Races file found!");
        }

        public static void loadRaces()
        {
            Races = FileHandler.FileHandler.Read<Dictionary<String, RaceInfo>>(
                FileHandler.FileHandler.ConfigFolder + "races.levi",
                typeof(RaceManager));
        }

        public static void saveRaces()
        {

            FileHandler.FileHandler.Write(FileHandler.FileHandler.ConfigFolder + "races.levi",
                Races,
                typeof(RaceManager));
        }

        public static List<Race> getRaces()
        {
            checkLoad();

            return Races.Keys.Select(x => new Race(x)).ToList<Race>();
        }

        public static Stats getStart(Race race)
        {
            checkLoad();

            if(!Races.ContainsKey(race.RaceName))
            {
                throw new Exceptions.MissingResourceException("Cannot find Race: " + race + ".");
            }

            return Races[race.RaceName].Start;
        }

        public static Stats getLevelUps(Race race)
        {
            checkLoad();

            if (!Races.ContainsKey(race.RaceName))
            {
                throw new Exceptions.MissingResourceException("Cannot find Race: " + race + ".");
            }

            return Races[race.RaceName].LevelUp;
        }

        public static List<String> getStartZones(Race race)
        {
            checkLoad();

            if (!Races.ContainsKey(race.RaceName))
            {
                throw new Exceptions.MissingResourceException("Cannot find Race: " + race + ".");
            }

            return Races[race.RaceName].StartZones;
        }

        public static Race getDefault()
        {
            checkLoad();

            return new Race(Races.First().Key);
        }

    }

}
