using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.View.ViewModel
{
    public class SkillsViewModel : ViewModelBase
    {

        #region Properties

        public ObservableCollection<Fields.SkillField> Items { get; private set; }

        public Model.CharacterRelated.Skills Skills { get; private set; }
        private Int32 _level;

        public Model.CharacterRelated.SkillRelated.Skill Selected { get; private set; }

        #endregion

        #region Events

        public event EventHandler SelectedSkillEvent;
        private void OnSelectedSkill(Model.CharacterRelated.SkillRelated.Skill sk)
        {
            if (SelectedSkillEvent != null)
            {
                Selected = sk;
                SelectedSkillEvent(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Ctors

        public SkillsViewModel(Model.CharacterRelated.Skills sk, Int32 lev)
        {
            Skills = sk;
            _level = lev;
            Items = new ObservableCollection<Fields.SkillField>();

            for(int i = 0; i < sk.SkillTree.Count; ++i)
            {
                Items.Add(new Fields.SkillField
                    {
                        Name = sk.SkillTree[i].DisplayName(),
                        ImageName = "",
                        LevelRequired = "lvl " + sk.SkillTree[i].LevelRequired().ToString(),
                        IsLearnable = !sk.UnlockedSkillIds.Contains(i) && sk.SkillTree[i].LevelRequired() <= _level && sk.UnSpentPoints > 0,
                        Tooltip = sk.SkillTree[i].ToolTip(),
                        LearnCommand = new DelegateCommand(x => LearnSkill(sk.SkillTree[i])),
                        SelectedCommand = new DelegateCommand(x => OnSelectedSkill(sk.SkillTree[i]))
                    });
            }
            OnPropertyChanged("Items");
        }

        #endregion

        #region Private Methods

        private void LearnSkill(Model.CharacterRelated.SkillRelated.Skill sk)
        {
            Int32 id = Skills.SkillTree.FindIndex(x => x == sk);

            if(!Skills.UnlockedSkillIds.Contains(id) && 
                Skills.SkillTree[id].LevelRequired() <= _level && 
                Skills.UnSpentPoints > 0)
            {
                Skills.UnlockedSkillIds.Add(id);
                --Skills.UnSpentPoints;
                //TODO
            }
            //TODO
        }

        #endregion

    }
}
