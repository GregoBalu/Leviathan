using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.ViewModel
{
    public class MenuViewModel : ViewModelBase
    {

        public DelegateCommand NewCommand { get; set; }
        public DelegateCommand LoadCommand { get; set; }
        public DelegateCommand QuitCommand { get; set; }

        #region Events

        public event EventHandler NewGameEvent;
        private void OnNewGameEvent()
        {
            if (NewGameEvent != null)
                NewGameEvent(this, EventArgs.Empty);
        }

        public event EventHandler LoadGameEvent;
        private void OnLoadGameEvent()
        {
            if (LoadGameEvent != null)
                LoadGameEvent(this, EventArgs.Empty);
        }

        public event EventHandler QuitGameEvent;
        private void OnQuitGameEvent()
        {
            if (QuitGameEvent != null)
                QuitGameEvent(this, EventArgs.Empty);
        }

        #endregion

        public MenuViewModel()
        {


            NewCommand = new DelegateCommand(x => OnNewGameEvent());
            LoadCommand = new DelegateCommand(x => OnLoadGameEvent());
            QuitCommand = new DelegateCommand(x => OnQuitGameEvent());
        }
    }
}
