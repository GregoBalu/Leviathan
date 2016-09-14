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

        public event EventHandler<Boolean> LearnedSkill;
        private void OnLearnedSkill(Boolean val)
        {
            if (LearnedSkill != null)
                LearnedSkill(this, val);
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
                        Name = sk.SkillTree[i].DisplayName,
                        ImageName = "",
                        LevelRequired = "lvl " + sk.SkillTree[i].LevelRequired.ToString(),
                        IsLearnable = !sk.SkillTree[i].IsUnlocked && 
                            sk.SkillTree[i].LevelRequired <= _level && sk.UnSpentPoints > 0,
                        Tooltip = sk.SkillTree[i].ToolTip,
                        LearnCommand = new DelegateCommand(x =>
                        {
                            if (LearnSkill(sk.SkillTree[i]))
                                OnLearnedSkill(true);
                            else
                                OnLearnedSkill(false);
                        }),
                        SelectedCommand = new DelegateCommand(x => OnSelectedSkill(sk.SkillTree[i]))
                    });
            }
            OnPropertyChanged("Items");
        }

        #endregion

        #region Private Methods

        private bool LearnSkill(Model.CharacterRelated.SkillRelated.Skill sk)
        {
            Int32 ind = Skills.SkillTree.FindIndex(x => x == sk);

            if(!Skills.SkillTree[ind].IsUnlocked && 
                Skills.SkillTree[ind].LevelRequired <= _level && 
                Skills.UnSpentPoints > 0)
            {
                Skills.SkillTree[ind].IsUnlocked = true;
                --Skills.UnSpentPoints;

                return true;
            }

            return false;
        }

        #endregion

    }
}
