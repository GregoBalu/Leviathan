using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.MapRelated
{
    public static class RegionManager
    {
        private static Dictionary<String, Map> _regions;

        private static void checkLoad()
        {
            if (_regions == null)
                loadRegions();

            if (_regions.Count == 0)
                throw new Exceptions.MissingResourceException("No Regions file found!");
        }

        private static void loadRegions()
        {
            _regions = FileHandler.FileHandler.Read<Dictionary<String, Map>>(
                FileHandler.FileHandler.ConfigFolder + "regions.levi",
                    typeof(RegionManager));
        }

        public static List<Region> getRegions()
        {
            checkLoad();

            return _regions.Keys.Select(x => new Region(x)).ToList();
        }

        public static Region getRegion(String maybeRegion)
        {
            checkLoad();

            if (_regions.ContainsKey(maybeRegion))
                return new Region(maybeRegion);

            throw new ArgumentOutOfRangeException("No region such as: " + maybeRegion + "!");
        }

        public static Map getMap(Region reg)
        {
            checkLoad();

            return _regions[reg.RegionName];
        }
    }
}
