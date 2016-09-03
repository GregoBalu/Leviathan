using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leviathan.Model.CharacterRelated.InventoryRelated;
using Leviathan.Model.Exceptions;

namespace Leviathan.Model.CharacterRelated
{
    public class Equipped
    {
        public ArmorSlot Armor { get; set; }

        public WeaponSlot Weapon { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public Stats BonusStats
        {
            get
            {
                Stats result = Stats.Null;

                if (Armor != null)
                    result += Armor.Stats;

                if (Weapon != null)
                    result += Weapon.Stats;

                return result;
            }
        }

        public Equipped()
        {
            
        }
    
    }
}
