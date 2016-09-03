using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.View.ViewModel.Fields
{
    public class OptionField : ViewModelBase
    {
        public Int32 Index { get; set; }

        public String OptionContent { get; set; }

        public DelegateCommand GoToCommand { get; set; }
    }
}
