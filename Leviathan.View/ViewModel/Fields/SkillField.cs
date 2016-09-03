using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.View.ViewModel.Fields
{
    public class SkillField : ViewModelBase
    {

        public Int32 Row { get; set; }

        public Int32 Column { get; set; }

        public String ImageName { get; set; }

        public String Tooltip { get; set; }

        private String _name;
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public String LevelRequired { get; set; }

        public Boolean IsLearnable { get; set; }

        public DelegateCommand LearnCommand { get; set; }

        public DelegateCommand SelectedCommand { get; set; }

    }
}
