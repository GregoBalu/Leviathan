using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public object CurrentView
        {
            get; private set;
        }

        public MainViewModel(object view)
        {
            CurrentView = view;
        }

        public void ChangeView(object view)
        {
            CurrentView = view;
            OnPropertyChanged("CurrentView");
        }
    }
}
