using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.ViewModel.Fields
{
    public class ItemField : ViewModelBase
    {
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

        private String _imageName;
        public String ImageName
        {
            get
            {
                return _imageName;
            }
            set
            {
                if (_imageName != value)
                {
                    _imageName = value;
                    OnPropertyChanged("ImageName");
                }
            }
        }

        public String Stats
        { get; set; }

        public DelegateCommand SelectedCommand { get; set; }

    }
}
