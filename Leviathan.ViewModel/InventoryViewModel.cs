using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leviathan;

namespace Leviathan.ViewModel
{
    public class InventoryViewModel : ViewModelBase
    {

        #region Properties

        public ObservableCollection<Fields.ItemField> Items { get; private set; }
        public Fields.ItemField Weapon { get; private set; }
        public Fields.ItemField Armor { get; private set; }

        public Model.CharacterRelated.Inventory Inventory { get; private set; }
        public Model.CharacterRelated.Equipped Equipped { get; private set; }

        #endregion

        #region Events


        #endregion

        #region Ctors

        public InventoryViewModel(Model.CharacterRelated.Character ch)
        {
            Items = new ObservableCollection<Fields.ItemField>();
            foreach(Model.CharacterRelated.InventoryRelated.Item it in ch.Inventory.Items)
            {
                Items.Add(new Fields.ItemField
                    {
                        Name = it.Name,
                        ImageName = Properties.Resources.ImagesFolder + Properties.Resources.ItemsFolder + it.ImageName + Properties.Resources.ImagesExtension,
                        Stats = it.Stats.ToString(),
                        SelectedCommand = new DelegateCommand(x => EquipItem(it))
                    });
            }

            if (ch.Equipped.Weapon != null)
            {
                Weapon = new Fields.ItemField
                {
                    Name = ch.Equipped.Weapon.Name,
                    ImageName = Properties.Resources.ImagesFolder + Properties.Resources.ItemsFolder + ch.Equipped.Weapon.ImageName + Properties.Resources.ImagesExtension,
                    Stats = ch.Equipped.Weapon.Stats.ToString(),
                    SelectedCommand = new DelegateCommand(x => UnEquipItem(ch.Equipped.Weapon))
                };
            }
            else
            {
                Weapon = new Fields.ItemField
                {
                    Name = "Weapon Slot",
                    ImageName = "",
                    Stats = "None."
                };
            }

            if (ch.Equipped.Armor != null)
            {
                Armor = new Fields.ItemField
                {
                    Name = ch.Equipped.Armor.Name,
                    ImageName = Properties.Resources.ImagesFolder + Properties.Resources.ItemsFolder + ch.Equipped.Armor.ImageName + Properties.Resources.ImagesExtension,
                    Stats = ch.Equipped.Armor.Stats.ToString(),
                    SelectedCommand = new DelegateCommand(x => UnEquipItem(ch.Equipped.Armor))
                };
            }
            else
            {
                Armor = new Fields.ItemField
                {
                    Name = "Armor Slot",
                    ImageName = "",
                    Stats = "None."
                };
            }

            Inventory = ch.Inventory;
            Equipped = ch.Equipped;
        }

        #endregion

        private void EquipItem(Model.CharacterRelated.InventoryRelated.Item item)
        {
            if(item is Model.CharacterRelated.InventoryRelated.WeaponSlot)
            {
                if (Equipped.Weapon != null)
                {
                    Inventory.Add(Equipped.Weapon);
                    Weapon.SelectedCommand = new DelegateCommand(x => EquipItem(Equipped.Weapon));
                    Items.Add(Weapon);
                }

                Inventory.Remove(item);
                Equipped.Weapon = (Model.CharacterRelated.InventoryRelated.WeaponSlot)item;

                Fields.ItemField f = Items.Where(i => i.Name == item.Name).First();
                Items.Remove(f);
                f.SelectedCommand = new DelegateCommand(x => UnEquipItem(item));
                Weapon = f;
                OnPropertyChanged("Weapon");
                OnPropertyChanged("Items");
            }
            else if (item is Model.CharacterRelated.InventoryRelated.ArmorSlot)
            {
                if(Equipped.Armor != null)
                {
                    Inventory.Add(Equipped.Armor);
                    Armor.SelectedCommand = new DelegateCommand(x => EquipItem(Equipped.Armor));
                    Items.Add(Armor);
                }
                    
                Inventory.Remove(item);
                Equipped.Armor = (Model.CharacterRelated.InventoryRelated.ArmorSlot)item;

                Fields.ItemField f = Items.Where(i => i.Name == item.Name).First();
                Items.Remove(f);
                f.SelectedCommand = new DelegateCommand(x => UnEquipItem(item));
                Armor = f;
                OnPropertyChanged("Armor");
                OnPropertyChanged("Items");
            }
        }

        private void UnEquipItem(Model.CharacterRelated.InventoryRelated.Item item)
        {
            if (item is Model.CharacterRelated.InventoryRelated.WeaponSlot)
            {
                Inventory.Add(Equipped.Weapon);
                Weapon.SelectedCommand = new DelegateCommand(x => EquipItem(item));
                Items.Add(Weapon);

                Equipped.Weapon = null;

                Weapon = new Fields.ItemField
                {
                    Name = "Weapon Slot",
                    ImageName = "",
                    Stats = "None.",
                    SelectedCommand = new DelegateCommand(x => {})
                };

                OnPropertyChanged("Weapon");
                OnPropertyChanged("Items");
            }
            else if (item is Model.CharacterRelated.InventoryRelated.ArmorSlot)
            {
                Inventory.Add(Equipped.Armor);
                Armor.SelectedCommand = new DelegateCommand(x => EquipItem(item));
                Items.Add(Armor);

                Equipped.Armor = null;

                Armor = new Fields.ItemField
                {
                    Name = "Armor Slot",
                    ImageName = "",
                    Stats = "None.",
                    SelectedCommand = new DelegateCommand(x => { })
                };

                OnPropertyChanged("Armor");
                OnPropertyChanged("Items");
            }
        }

    }
}
