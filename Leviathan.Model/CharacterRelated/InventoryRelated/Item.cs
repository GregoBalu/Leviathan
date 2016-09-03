using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.Model.CharacterRelated.InventoryRelated
{
    public abstract class Item
    {
        protected Stats _stats;
        public Stats Stats
        {
            get { return _stats; }
        }

        public String ImageName { get; protected set; }

        public abstract String Name { get; }

        public static Item DeSerialize(String value)
        {
            switch(value)
            {
                case "Leather Armor":
                    return new Armors.Leather();
                case "Bronze Sword":
                    return new Weapons.BronzeSword();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
