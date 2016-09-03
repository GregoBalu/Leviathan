using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leviathan.View.ViewModel.Fields
{
    public class LoadGameField : ViewModelBase
    {
        public String CharacterName { get; set; }

        public DateTime LastModifyDate { get; set; }

        public DelegateCommand SelectCommand { get; set; }
    }
}
