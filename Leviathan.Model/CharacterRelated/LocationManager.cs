using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated
{
    public static class LocationManager
    {

        public static Location Start(Race r, Profession c, Int32 alt)
        {
            return new Location(MapRelated.RegionManager.getRegion(RaceManager.getStartZones(r)[alt]), 0);
        }
    }
}
