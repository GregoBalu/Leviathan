using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leviathan;

namespace Leviathan.ViewModel
{
    public class NewCharacterViewModel : ViewModelBase
    {

        #region Properties

        public String Name { get; set; }
        public ObservableCollection<String> Races {get; set;}
        public String Race { get; set; }
        public ObservableCollection<String> Classes { get; set; }
        public String Class { get; set; }
        public Int32 Alternative { get; set; }

        public DelegateCommand OkCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }

        #endregion

        #region Events

        public event EventHandler<String> Ok;
        private void OnOk(String s)
        {
            if (Ok != null)
                Ok(this, s);
        }

        public event EventHandler Cancel;
        private void OnCancel()
        {
            if (Cancel != null)
                Cancel(this, EventArgs.Empty);
        }

        public event EventHandler<String> Message;
        private void OnMessage(String msg)
        {
            if (Message != null)
                Message(this, msg);
        }

        #endregion

        public NewCharacterViewModel()
        {
            OkCommand = new DelegateCommand(x =>
            {
                if (Name == null || Name == "")
                {
                    OnMessage("Name must be given!");
                    return;
                }
                if (Class == null || Class == "")
                {
                    OnMessage("You must select a Class!");
                    return;
                }
                if (Race == null || Race == "")
                {
                    OnMessage("You must select a Race!");
                    return;
                }

                Model.CharacterRelated.Character ch = new Model.CharacterRelated.Character();
                ch.Name = Name;
                ch.Race = new Model.CharacterRelated.Race(Race);
                ch.Class = new Model.CharacterRelated.Profession(Class);
                ch.Location = Model.CharacterRelated.LocationManager.Start(
                    ch.Race, ch.Class, Alternative);
                ch.BaseStats = Model.CharacterRelated.StatRelated.StatManager.Default(
                    ch.Race, ch.Class);

                String folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                    Properties.Resources.CharactersFolder;
                String filepath = folderpath + Name + Properties.Resources.CharactersExtension;
                if (!System.IO.Directory.Exists(folderpath))
                {
                    System.IO.Directory.CreateDirectory(folderpath);
                }
                if (!System.IO.File.Exists(filepath))
                {
                    FileHandler.FileHandler.Write(filepath, 
                        ch, 
                        typeof(Model.MapRelated.Map));
                    OnOk(filepath);
                }
                else
                    OnMessage("Character already exists with that name!");
            });
            CancelCommand = new DelegateCommand(x => OnCancel());

            Races = new ObservableCollection<String>();
            foreach(Model.CharacterRelated.Race r in Model.CharacterRelated.RaceManager.getRaces())
            {
                Races.Add(r.RaceName);
            }
            Race = Model.CharacterRelated.RaceManager.getRaces()[0].RaceName;


            Classes = new ObservableCollection<String>();
            foreach (Model.CharacterRelated.Profession p in Model.CharacterRelated.ProfessionManager.getProfessions())
            {
                Classes.Add(p.ProfessionName);
            }

            Alternative = 0;

        }
    }
}
