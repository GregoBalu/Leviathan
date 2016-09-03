using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leviathan.Model.Exceptions;

namespace Leviathan.Model.CharacterRelated.InventoryRelated.Armors
{
    public class Leather : ArmorSlot
    {

        public override String Name
        {
            get
            {
                return "Leather Armor";
            }
        }

        public Leather()
        {
            ImageName = "leather_armor";

            _stats = Stats.Null;
            _stats.Defense.Max = 1;
            _stats.Defense.Min = 0;
        }
    }
}
