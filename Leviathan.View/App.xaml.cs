using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Leviathan.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ViewModel.MainViewModel _mainViewModel;
        private View.MainWindow _mainWindow;
        private Window _dialogWindow;

        private Model.CharacterRelated.Character _tempPlayer;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Views.MenuView menu = new Views.MenuView();
            ViewModel.MenuViewModel menuVM = new ViewModel.MenuViewModel();
            menuVM.NewGameEvent += new EventHandler(Menu_New);
            menuVM.LoadGameEvent += new EventHandler(Menu_Load);
            menuVM.QuitGameEvent += new EventHandler(Menu_Quit);
            menu.DataContext = menuVM;

            _mainViewModel = new ViewModel.MainViewModel(menu);
            _mainWindow = new View.MainWindow();

            _mainWindow.DataContext = _mainViewModel;
            _mainWindow.Show();
        }

        private void ChangeView(object view)
        {
            _mainViewModel.ChangeView(view);
        }

        private void Menu_New(object sender, EventArgs e)
        {
            Views.NewCharacterView ngame = new Views.NewCharacterView();
            ViewModel.NewCharacterViewModel ngameVM = new ViewModel.NewCharacterViewModel();
            ngameVM.Ok += new EventHandler<String>(NewGame_Ok);
            ngameVM.Cancel += new EventHandler(NewGame_Cancel);
            ngameVM.Message += new EventHandler<string>(ShowMessage);
            ngame.DataContext = ngameVM;

            ChangeView(ngame);
        }

        private void NewGame_Ok(object sender, String e)
        {
            ToGame(e);
        }

        private void ToGame(String filepath)
        {
            SplashScreen loading_screen = new SplashScreen("Resources/loading.gif");
            loading_screen.Show(false, true);
            try
            {
                Views.GameView game = new Views.GameView();
                ViewModel.GameViewModel gameVM = new ViewModel.GameViewModel(filepath);
                gameVM.ShowMessageEvent += new EventHandler<string>(ShowMessage);
                gameVM.QuitEvent += new EventHandler(Game_Quit);
                gameVM.LoadEvent += new EventHandler(Menu_Load);
                gameVM.NewEvent += new EventHandler(Menu_New);
                gameVM.BattleEvent += new EventHandler(Game_Battle);
                gameVM.ShowStatsEvent += new EventHandler(Game_Stats);
                gameVM.ShowInventoryEvent += new EventHandler(Game_Inventory);
                gameVM.SelectSkillEvent += new EventHandler(Battle_SelectSkill);
                gameVM.SelectTargetEvent += new EventHandler(Battle_SelectTarget);
                gameVM.ViewEnemyEvent += new EventHandler<Model.CharacterRelated.Character>(Battle_ViewEnemy);
                gameVM.SelectedTargetEvent += new EventHandler(Battle_SelectedTarget);

                game.DataContext = gameVM;

                ChangeView(game);
            }
            catch(ViewModel.Exceptions.LoadException ex)
            {
                ShowMessage(this, ex.Message);
                Game_Quit(this, EventArgs.Empty);
            }
            finally
            {
                loading_screen.Close(TimeSpan.FromSeconds(1));
            }
        }

        private void Game_Battle(object sender, EventArgs e)
        {
            Views.BattleView battle = new Views.BattleView();
            battle.DataContext = (ViewModel.GameViewModel)sender;

            ChangeView(battle);
        }

        private void Game_Stats(object sender, EventArgs e)
        {
            ViewModel.GameViewModel gameVM = (ViewModel.GameViewModel)sender;
            Views.CharacterWindow chwnd = new Views.CharacterWindow();
            _tempPlayer = gameVM.Player;
            ViewModel.CharacterViewModel cvm = new ViewModel.CharacterViewModel(_tempPlayer, true);
            cvm.ShowInventory += new EventHandler<Model.CharacterRelated.Character>(Stats_Inventory);
            cvm.ShowSkills += new EventHandler<Model.CharacterRelated.Character>(Stats_Skills);
            
            chwnd.DataContext = cvm;

            chwnd.ShowDialog();

            gameVM.Player.Inventory = _tempPlayer.Inventory;
            gameVM.Player.Equipped = _tempPlayer.Equipped;
            gameVM.Player.Skills = _tempPlayer.Skills;

            _tempPlayer = null;
        }

        private void Stats_Inventory(object sender, Model.CharacterRelated.Character e)
        {
            Views.InventoryWindow iwnd = new Views.InventoryWindow();
            ViewModel.InventoryViewModel ivm = new ViewModel.InventoryViewModel(e);
            iwnd.DataContext = ivm;

            iwnd.ShowDialog();

            if (_tempPlayer != null)
            {
                _tempPlayer.Inventory = ivm.Inventory;
                _tempPlayer.Equipped = ivm.Equipped;

                if(sender is ViewModel.CharacterViewModel)
                {
                    ViewModel.CharacterViewModel cvm = (ViewModel.CharacterViewModel)sender;
                    cvm.UpdateStats(_tempPlayer.TotalStats);
                }
            }
        }

        private void Stats_Skills(object sender, Model.CharacterRelated.Character e)
        {
            Views.SkillsWindow swnd = new Views.SkillsWindow();
            ViewModel.SkillsViewModel svm = new ViewModel.SkillsViewModel(e.Skills, e.BaseStats.Experience.Level);
            swnd.DataContext = svm;

            swnd.ShowDialog();

            _tempPlayer.Skills = svm.Skills;
        }

        private void Game_Inventory(object sender, EventArgs e)
        {
            ViewModel.GameViewModel gameVM = (ViewModel.GameViewModel)sender;
            _tempPlayer = gameVM.Player;
            Stats_Inventory(sender, _tempPlayer);

            gameVM.Player.Inventory = _tempPlayer.Inventory;
            gameVM.Player.Equipped = _tempPlayer.Equipped;

            _tempPlayer = null;
        }

        private void Battle_SelectSkill(object sender, EventArgs e)
        {
            ViewModel.GameViewModel gameVM = (ViewModel.GameViewModel)sender;
            Views.SkillsWindow swnd = new Views.SkillsWindow();
            ViewModel.SkillsViewModel svm = new ViewModel.SkillsViewModel(gameVM.Player.Skills, gameVM.Player.BaseStats.Experience.Level);
            svm.SelectedSkillEvent += new EventHandler(Battle_SelectedSkill);
            swnd.DataContext = svm;

            _dialogWindow = swnd;
            swnd.ShowDialog();
            _dialogWindow = null;

            if(svm != null)
                gameVM.SelectSkill(svm.Selected);
            gameVM.Player.Skills = svm.Skills;
        }

        private void Battle_SelectedSkill(object sender, EventArgs e)
        {
            _dialogWindow.Close();
        }

        private void Battle_SelectTarget(object sender, EventArgs e)
        {
            ViewModel.GameViewModel gameVM = (ViewModel.GameViewModel)sender;
            Views.TargetSelectWindow tswnd = new Views.TargetSelectWindow();
            tswnd.DataContext = gameVM;

            _dialogWindow = tswnd;
            tswnd.ShowDialog();
            _dialogWindow = null;
        }

        private void Battle_SelectedTarget(object sender, EventArgs e)
        {
            _dialogWindow.Close();
        }

        private void Battle_ViewEnemy(object sender, Model.CharacterRelated.Character e)
        {
            Views.CharacterWindow chwnd = new Views.CharacterWindow();
            ViewModel.CharacterViewModel cvm = new ViewModel.CharacterViewModel(e);

            chwnd.DataContext = cvm;

            chwnd.ShowDialog();
        }

        private void Game_Quit(object sender, EventArgs e)
        {
            ToMenu();
        }

        private void NewGame_Cancel(object sender, EventArgs e)
        {
            Views.MenuView menu = new Views.MenuView();
            ViewModel.MenuViewModel menuVM = new ViewModel.MenuViewModel();
            menuVM.NewGameEvent += new EventHandler(Menu_New);
            menuVM.LoadGameEvent += new EventHandler(Menu_Load);
            menuVM.QuitGameEvent += new EventHandler(Menu_Quit);
            menu.DataContext = menuVM;

            ChangeView(menu);
        }

        private void ShowMessage(object sender, String s)
        {
            MessageBox.Show(s, "Warning");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Views.LoadView load = new Views.LoadView();
            ViewModel.LoadViewModel loadVM = new ViewModel.LoadViewModel();
            loadVM.Back += new EventHandler(Load_Back);
            loadVM.FilePicked += new EventHandler<String>(Load_Picked);
            load.DataContext = loadVM;

            ChangeView(load);
        }

        private void Load_Picked(object sender, String e)
        {
            ToGame(e);
        }

        private void Load_Back(object sender, EventArgs e)
        {
            ToMenu();
        }

        private void Menu_Quit(object sender, EventArgs e)
        {
            this.Shutdown();
        }

        private void ToMenu()
        {
            Views.MenuView menu = new Views.MenuView();
            ViewModel.MenuViewModel menuVM = new ViewModel.MenuViewModel();
            menuVM.NewGameEvent += new EventHandler(Menu_New);
            menuVM.LoadGameEvent += new EventHandler(Menu_Load);
            menuVM.QuitGameEvent += new EventHandler(Menu_Quit);
            menu.DataContext = menuVM;

            ChangeView(menu);
        }

    }
}
