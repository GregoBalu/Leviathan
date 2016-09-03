using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leviathan.Model.CharacterRelated.InventoryRelated;
using Leviathan.Model.Exceptions;

namespace Leviathan.Model.CharacterRelated
{
    public class Inventory
    {

        public List<Item> Items { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public Int32 Count
        {
            get
            {
                return Items.Count;
            }
        }

        
        public Inventory()
        {
            Items = new List<Item>();
        }

        public void Add(Item it)
        {
            Items.Add(it);
        }

        public Boolean Remove(Item it)
        {
            return Items.Remove(it);
        }

    }
}
