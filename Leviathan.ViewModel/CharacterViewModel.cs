using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leviathan;

namespace Leviathan.ViewModel
{
    public class CharacterViewModel : ViewModelBase
    {

        #region Properties

        public String Name { get; private set; }
        public String Level { get; private set; }
        public String Race { get; private set; }
        public String Class { get; private set; }
        public String Health { get; private set; }
        public String Mana { get; private set; }
        public String Attack { get; private set; }
        public String Defense { get; private set; }
        public String Speed { get; private set; }
        public String Experience { get; private set; }

        public Boolean IsSkillsEnabled { get; private set; }
        public Boolean IsInventoryEnabled { get; private set; }

        public DelegateCommand SkillsCommand { get; private set; }
        public DelegateCommand InventoryCommand { get; private set; }

        #endregion

        #region Events

        public event EventHandler<Model.CharacterRelated.Character> ShowSkills;
        private void OnShowSkills(Model.CharacterRelated.Character ch)
        {
            if (ShowSkills != null)
                ShowSkills(this, ch);
        }

        public event EventHandler<Model.CharacterRelated.Character> ShowInventory;
        private void OnShowInventory(Model.CharacterRelated.Character ch)
        {
            if (ShowInventory != null)
                ShowInventory(this, ch);
        }

        #endregion

        public CharacterViewModel(Model.CharacterRelated.Character ch, Boolean isPlayer = false)
        {
            Name = ch.Name;
            Level = ch.TotalStats.Experience.Level.ToString() + " lvl";
            Race = ch.Race.RaceName;
            Class = ch.Class.ProfessionName;
            Health = ch.TotalStats.Health.Current + "/" + ch.TotalStats.Health.Max;
            Mana = ch.TotalStats.Mana.Current + "/" + ch.TotalStats.Mana.Max;
            Attack = ch.TotalStats.Attack.ToString();
            Defense = ch.TotalStats.Defense.ToString();
            Speed = ch.TotalStats.Speed.ToString();
            Experience = ch.TotalStats.Experience.Current.ToString() + " xp";
            IsSkillsEnabled = isPlayer;
            IsInventoryEnabled = isPlayer;

            SkillsCommand = new DelegateCommand(x => OnShowSkills(ch));
            InventoryCommand = new DelegateCommand(x => OnShowInventory(ch));
        }

        public void UpdateStats(Model.CharacterRelated.Stats st)
        {
            Level = st.Experience.Level.ToString() + " lvl";
            Health = st.Health.Current + "/" + st.Health.Max;
            Mana = st.Mana.Current + "/" + st.Mana.Max;
            Attack = st.Attack.ToString();
            Defense = st.Defense.ToString();
            Speed = st.Speed.ToString();
            Experience = st.Experience.Current.ToString() + " xp";

            OnPropertyChanged("Level");
            OnPropertyChanged("Health");
            OnPropertyChanged("Mana");
            OnPropertyChanged("Attack");
            OnPropertyChanged("Defense");
            OnPropertyChanged("Speed");
            OnPropertyChanged("Experience");
        }

    }
}
