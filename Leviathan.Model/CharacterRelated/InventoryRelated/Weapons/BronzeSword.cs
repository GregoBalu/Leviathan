using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leviathan.Model.Exceptions;

namespace Leviathan.Model.CharacterRelated.InventoryRelated.Weapons
{
    public class BronzeSword : WeaponSlot
    {

        public override String Name
        {
            get
            {
                return "Bronze Sword";
            }
        }

        public BronzeSword()
        {
            ImageName = "bronze_sword";

            _stats = Stats.Null;
            _stats.Attack.Max = 1;
            _stats.Attack.Min = 0;
        }
    }
}
