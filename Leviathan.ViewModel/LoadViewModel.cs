using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Leviathan.ViewModel
{
    public class LoadViewModel : ViewModelBase
    {
        #region Properties

        public ObservableCollection<Fields.LoadGameField> LoadGames { get; private set; }

        #endregion

        #region Commands

        public DelegateCommand BackCommand { get; set; }

        public DelegateCommand LoadCommand { get; set; }

        #endregion

        #region Events

        public event EventHandler Back;
        private void OnBack()
        {
            if (Back != null)
                Back(this, EventArgs.Empty);
        }

        public event EventHandler<String> FilePicked;
        private void OnFilePicked(String path)
        {
            if (FilePicked != null)
                FilePicked(this, path);
        }

        #endregion

        public LoadViewModel()
        {
            BackCommand = new DelegateCommand(x => OnBack());
            LoadCommand = new DelegateCommand(x => OnFilePicked(""));

            LoadGames = new ObservableCollection<Fields.LoadGameField>();
            ReadSavedGames();

        }

        private void ReadSavedGames()
        {
            String saveFolderPath = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                Properties.Resources.CharactersFolder;

            foreach(String filepath in System.IO.Directory.EnumerateFiles(saveFolderPath))
            {
                string fileName = filepath.Substring(saveFolderPath.Length);
                LoadGames.Add(new Fields.LoadGameField
                {
                    CharacterName = fileName.Split('.')[0],
                    LastModifyDate = System.IO.File.GetLastWriteTime(filepath),
                    SelectCommand = new DelegateCommand(x => OnFilePicked(filepath))
                });
            }

        }

    }
}
