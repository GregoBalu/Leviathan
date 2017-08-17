using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Leviathan;

namespace Leviathan.ViewModel
{
    public class GameViewModel : ViewModelBase
    {
        #region Properties

        public String Content { get; set; }
        public String ImageName { get; set;}
        public ObservableCollection<Fields.OptionField> Options { get; set; }

        public DelegateCommand NewCommand { get; private set; }
        public DelegateCommand SaveCommand { get; private set; }
        public DelegateCommand LoadCommand { get; private set; }
        public DelegateCommand QuitCommand { get; private set; }

        public DelegateCommand StatsCommand { get; private set; }
        public DelegateCommand InventoryCommand { get; private set; }

        public String Battle_MyHealth
        {
            get
            {
                return _player.TotalStats.Health.Current + " / " + _player.TotalStats.Health.Max;
            }
        }
        public String Battle_MyMana
        {
            get
            {
                return _player.TotalStats.Mana.Current + " / " + _player.TotalStats.Mana.Max;
            }
        }
        private Int32 _target;
        public String Battle_EnemyHealth
        {
            get
            {
                return _map.Current.Special.Enemies[_target].TotalStats.Health.Current +
                    " / " + _map.Current.Special.Enemies[_target].TotalStats.Health.Max;
            }
        }
        public String Battle_EnemyMana
        {
            get
            {
                return _map.Current.Special.Enemies[_target].TotalStats.Mana.Current +
                    " / " + _map.Current.Special.Enemies[_target].TotalStats.Mana.Max;
            }
        }
        public String Battle_EnemyDistance
        {
            get
            {
                return _map.Current.Special.Distances[_target] + " m";
            }
        }
        public Boolean Battle_IsTargetSelected
        {
            get
            {
                return _target >= 0;
            }
        }
        public Boolean Battle_IsTargetNotSelected
        {
            get
            {
                return !(_target >= 0);
            }
        }
        public String Battle_Content { get; private set; }

        public Int32 Battle_EnemyCount
        {
            get
            {
                return _map.Current.Special.Enemies.Count();
            }
        }
        public Int32 Battle_KilledEnemies
        {
            get
            {
                return _map.Current.Special.Enemies.Count(e => e.TotalStats.Health.Current <= 0);
            }
        }

        public DelegateCommand Battle_SelectSkill { get; private set; }
        public DelegateCommand Battle_SelectTarget { get; private set; }
        public DelegateCommand Battle_ViewEnemy { get; private set; }

        public DelegateCommand Battle_SelectNearest { get; private set; }
        public DelegateCommand Battle_SelectFarthest { get; private set; }
        public DelegateCommand Battle_SelectLowestHealth { get; private set; }
        public DelegateCommand Battle_SelectHighestHealth { get; private set; }
        public DelegateCommand Battle_SelectPrevious { get; private set; }
        public DelegateCommand Battle_SelectRandom { get; private set; }
        public DelegateCommand Battle_SelectFastest { get; private set; }
        public DelegateCommand Battle_SelectSlowest { get; private set; }

        #endregion

        #region Privates

        private Model.MapRelated.Map _map;
        private Model.CharacterRelated.Character _player;
        public Model.CharacterRelated.Character Player
        {
            get
            {
                return _player;
            }
            set
            {
                //TODO
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Events

        public event EventHandler<String> GameOverEvent;
        private void OnGameOver(String msg)
        {
            if (GameOverEvent != null)
                GameOverEvent(this, msg);
        }

        public event EventHandler BattleEvent;
        private void OnBattle()
        {
            if (BattleEvent != null)
                BattleEvent(this, EventArgs.Empty);
        }

        public event EventHandler BattleEndEvent;
        private void OnBattleEnd()
        {
            if (BattleEndEvent != null)
                BattleEndEvent(this, EventArgs.Empty);
        }

        public event EventHandler NewEvent;
        private void OnNew()
        {
            if (NewEvent != null)
                NewEvent(this, EventArgs.Empty);
        }

        public event EventHandler LoadEvent;
        private void OnLoad()
        {
            if (LoadEvent != null)
                LoadEvent(this, EventArgs.Empty);
        }

        public event EventHandler QuitEvent;
        private void OnQuit()
        {
            if (QuitEvent != null)
                QuitEvent(this, EventArgs.Empty);
        }

        public event EventHandler ShowStatsEvent;
        private void OnShowStats()
        {
            if (ShowStatsEvent != null)
                ShowStatsEvent(this, EventArgs.Empty);
        }

        public event EventHandler ShowInventoryEvent;
        private void OnShowInventory()
        {
            if (ShowInventoryEvent != null)
                ShowInventoryEvent(this, EventArgs.Empty);
        }

        public event EventHandler SelectSkillEvent;
        private void OnSelectSkill()
        {
            if (SelectSkillEvent != null)
                SelectSkillEvent(this, EventArgs.Empty);
        }

        public event EventHandler SelectTargetEvent;
        private void OnSelectTarget()
        {
            if (SelectTargetEvent != null)
                SelectTargetEvent(this, EventArgs.Empty);
        }

        public event EventHandler SelectedTargetEvent;
        private void OnSelectedTarget()
        {
            if (SelectedTargetEvent != null)
                SelectedTargetEvent(this, EventArgs.Empty);
        }

        public event EventHandler<Model.CharacterRelated.Character> ViewEnemyEvent;
        private void OnViewEnemy(Model.CharacterRelated.Character ch)
        {
            if (ViewEnemyEvent != null)
                ViewEnemyEvent(this, ch);
        }

        public event EventHandler<String> ShowMessageEvent;
        private void OnShowMessage(String msg)
        {
            if (ShowMessageEvent != null)
                ShowMessageEvent(this, msg);
        }

        #endregion

        public GameViewModel(String filepath)
        {
            Options = new ObservableCollection<Fields.OptionField>();

            NewCommand = new DelegateCommand(x => OnNew());
            SaveCommand = new DelegateCommand(x =>
            {
                FileHandler.FileHandler.Write(filepath, 
                    _player,
                    typeof(Model.MapRelated.Map));
                OnShowMessage("Save successfully completed!");
            });
            LoadCommand = new DelegateCommand(x => OnLoad());
            QuitCommand = new DelegateCommand(x => OnQuit());

            StatsCommand = new DelegateCommand(x => OnShowStats());
            InventoryCommand = new DelegateCommand(x => OnShowInventory());

            //Set up map & player
            try
            {
                _player = FileHandler.FileHandler.Read<Model.CharacterRelated.Character>(
                    filepath,
                    typeof(Model.MapRelated.Map));
            }
            catch(FileHandler.Exceptions.ReadException ex)
            {
                throw new Exceptions.LoadException(ex.Message);
            }

            try
            {
                _map = Model.MapRelated.RegionManager.getMap(_player.Location.Region);
                _map.SetUp(_player.Location.SubRegion);
            }
            catch
            {
                throw new Exceptions.LoadException("The selected map file is missing or corrupted. Cannot load character.");
            }

            _map.Battle += new EventHandler(Map_Battle);
            _map.VariableSet += new EventHandler(Map_VariableSet);
            _map.ExperienceGain += new EventHandler(Map_ExperienceGain);
            _map.ItemGain += new EventHandler(Map_ItemGain);
            _map.ChangeRegion += new EventHandler(Map_ChangeRegion);

            RefreshView();
        }

        private void RefreshView()
        {
            Content = _map.Current.Content;
            OnPropertyChanged("Content");
            ImageName = _map.Current.ImageName;
            OnPropertyChanged("ImageName");
            Options.Clear();
            for(Int32 i = 0; i < _map.Current.Options.Count; ++i)
            {
                if (!_map.Current.Options[i].Condition.IsTrue(_player.Location.History))
                    continue;

                Int32 toId = _map.Current.Options[i].ToId;
                Options.Add(new Fields.OptionField
                {
                    Index = i,
                    OptionContent = _map.Current.Options[i].Content,
                    GoToCommand = new DelegateCommand(x => GoToSegment(toId))
                });
            }
            OnPropertyChanged("Options");
        }

        private void Map_Battle(object sender, EventArgs e)
        {
            _target = -1;
            Battle_SelectSkill = new DelegateCommand(x => OnSelectSkill());
            Battle_SelectTarget = new DelegateCommand(x => OnSelectTarget());
            Battle_ViewEnemy = new DelegateCommand(x => OnViewEnemy(_map.Current.Special.Enemies[_target]));
            Battle_Content = "The battle begins..." + Environment.NewLine;

            Battle_SelectFarthest = new DelegateCommand(x =>
                {
                    Int32 max_i = -1;
                    Int32 max = -1;
                    for(Int32 i = 0; i < _map.Current.Special.Enemies.Count; ++i)
                    {
                        if(_map.Current.Special.Distances[i] > max)
                        {
                            max_i = i;
                            max = _map.Current.Special.Distances[i];
                        }
                    }

                    if(max_i == -1)
                        throw new Exception();
                    SelectTarget(max_i);
                });
            Battle_SelectNearest = new DelegateCommand(x =>
            {
                Int32 min_i = -1;
                Int32 min = Int32.MaxValue;
                for (Int32 i = 0; i < _map.Current.Special.Enemies.Count; ++i)
                {
                    if (_map.Current.Special.Distances[i] < min)
                    {
                        min_i = i;
                        min = _map.Current.Special.Distances[i];
                    }
                }

                if (min_i == -1)
                    throw new Exception();
                SelectTarget(min_i);
            });
            Battle_SelectLowestHealth = new DelegateCommand(x =>
            {
                Int32 lowest = _map.Current.Special.Enemies.Min(enemy =>
                    enemy.TotalStats.Health.Current);
                Int32 i = _map.Current.Special.Enemies.IndexOf(_map.Current.Special.Enemies.First(enemy =>
                    enemy.TotalStats.Health.Current == lowest));
                SelectTarget(i);
            });
            Battle_SelectHighestHealth = new DelegateCommand(x =>
            {
                Int32 highest = _map.Current.Special.Enemies.Max(enemy =>
                    enemy.TotalStats.Health.Current);
                Int32 i = _map.Current.Special.Enemies.IndexOf(_map.Current.Special.Enemies.First(enemy =>
                    enemy.TotalStats.Health.Current == highest));
                SelectTarget(i);
            });
            Battle_SelectSlowest = new DelegateCommand(x =>
            {
                Int32 slowest = _map.Current.Special.Enemies.Min(enemy =>
                    enemy.TotalStats.Speed);
                Int32 i = _map.Current.Special.Enemies.IndexOf(_map.Current.Special.Enemies.First(enemy =>
                    enemy.TotalStats.Speed == slowest));
                SelectTarget(i);
            });
            Battle_SelectFastest = new DelegateCommand(x =>
            {
                Int32 fastest = _map.Current.Special.Enemies.Max(enemy =>
                    enemy.TotalStats.Speed);
                Int32 i = _map.Current.Special.Enemies.IndexOf(_map.Current.Special.Enemies.First(enemy =>
                    enemy.TotalStats.Speed == fastest));
                SelectTarget(i);
            });
            Battle_SelectPrevious = new DelegateCommand(x =>
            {
                SelectTarget(-1, true);
            });
            Battle_SelectRandom = new DelegateCommand(x =>
            {
                Random r = new Random(DateTime.Now.Millisecond);
                SelectTarget(r.Next(0, _map.Current.Special.Enemies.Count - 1));
            });


            OnBattle();
        }

        private void Map_VariableSet(object sender, EventArgs e)
        {
            if(!_player.Location.History.Keys.Contains(_map.Current.Special.VariableName))
            {
                _player.Location.History.Add(_map.Current.Special.VariableName, 
                    _map.Current.Special.VariableValue);
            }
            else
            {
                _player.Location.History[_map.Current.Special.VariableName] =
                    _map.Current.Special.VariableValue;
            }
            GoToSegment(_map.Current.Options.First().ToId);
        }

        private void Map_ExperienceGain(object sender, EventArgs e)
        {
            _player.BaseStats.Experience.Gain(_map.Current.Special.ExperienceAmount);
            GoToSegment(_map.Current.Options.First().ToId);
        }

        private void Map_ItemGain(object sender, EventArgs e)
        {
            _player.Inventory.Add(_map.Current.Special.ItemToGet);
            GoToSegment(_map.Current.Options.First().ToId);
        }

        private void Map_ChangeRegion(object sender, EventArgs e)
        {
            _map = Model.MapRelated.RegionManager.getMap(_map.Current.Special.NewRegionName);
            RefreshView();
        }

        private void GoToSegment(Int32 to)
        {
            _map.GoToSegment(to);
            _player.Location.Region = _map.Region;
            _player.Location.SubRegion = to;
            RefreshView();
        }

        public void SelectTarget(Int32 i, Boolean prev = false)
        {
            if (prev && _target == -1)
            {
                OnShowMessage("There was no previous target or the previous one is dead.");
                OnSelectTarget();
                return;
            }
            if (prev)
                i = _target;

            OnSelectedTarget();
            _target = i;
            OnPropertyChanged("Battle_EnemyHealth");
            OnPropertyChanged("Battle_EnemyMana");
            OnPropertyChanged("Battle_EnemyDistance");
            OnPropertyChanged("Battle_IsTargetSelected");
            OnPropertyChanged("Battle_IsTargetNotSelected");
        }

        public void SelectSkill(Model.CharacterRelated.SkillRelated.Skill sk)
        {
            if(_target == -1)
            {
                OnShowMessage("Select a target!");
                return;
            }

            if(_player.TotalStats.Mana.Current < sk.ManaCost)
            {
                OnShowMessage("You need more mana to cast that!");
                return;
            }

            if (_map.Current.Special.Distances[_target] > sk.Range)
            {
                Battle_Content += "You run closer to your target and your enemies." + Environment.NewLine;
                OnPropertyChanged("Battle_Content");
                for(Int32 i = 0; i < _map.Current.Special.Distances.Count; ++i)
                {
                    if (_map.Current.Special.Enemies[i].TotalStats.Health.Current <= 0)
                        continue;

                    if(i==_target)
                    {
                        if (_map.Current.Special.Distances[i] == 0)
                            continue;

                        _map.Current.Special.Distances[i] -= _player.TotalStats.Speed;
                    }
                    else
                    {
                        if(_map.Current.Special.Distances[i] == 0)
                            continue;

                        _map.Current.Special.Distances[i] -= _player.TotalStats.Speed / 2;
                    }
                }
                OnPropertyChanged("Battle_EnemyDistance");
                return;
            }

            _player.BaseStats.Mana.Consume(sk.ManaCost);
            _player.Skills.SkillTree.Find(skill => skill == sk).IsOnCooldown = 
                _player.Skills.SkillTree.Find(skill => skill == sk).Cooldown;
            _player.ActiveEffects.Add(sk);

            //Add skill stats

            _player.BaseStats.Attack += sk.AdditionalAttack;
            _player.BaseStats.Defense += sk.AdditionalDefense;
            _player.BaseStats.Health.Increase(sk.AdditionalHealth);
            _player.BaseStats.Health.Heal(sk.Heal);
            _player.BaseStats.Mana.Increase(sk.AdditionalMana);
            _player.BaseStats.Mana.Regen(sk.Recover);
            _player.BaseStats.Speed += sk.AdditionalSpeed;
            Battle_Content += sk.UseMessage + Environment.NewLine;
            OnPropertyChanged("Battle_Content");

            //DO damage
            HitEnemy();

            //enemy turn
            for (Int32 i = 0; i < _map.Current.Special.Enemies.Count; ++i)
            {
                if (_map.Current.Special.Enemies[i].TotalStats.Health.Current <= 0)
                    continue;

                EnemyTurn(i);
            }

            //remove effects
            EndOfTurnMaintainPlayer();

            //if end
            if(_map.Current.Special.Enemies.All(enemy => enemy.TotalStats.Health.Current <= 0))
            {
                while(_player.ActiveEffects.Count > 0)
                {
                    EndOfTurnMaintainPlayer();
                }

                OnBattleEnd();
            }
        }

        private void HitEnemy()
        {
            Int32 actual = _map.Current.Special.Enemies[_target].TotalStats.Damage(_player.TotalStats.Attack.Value);
            if (_map.Current.Special.Enemies[_target].TotalStats.Health.Current <= 0)
                _target = -1;

            Battle_Content += "You did " + _player.TotalStats.Attack.Value.ToString() + 
                " damage to " + _map.Current.Special.Enemies[_target].Name +
                " while it blocked " + (_player.TotalStats.Attack.Value - actual).ToString() +
                " amount, resulting in an actual damage of " + actual.ToString() + "." + 
                Environment.NewLine;
            OnPropertyChanged("Battle_Content");
            OnChangePlayer();
            OnChangeEnemy();
        }

        private void EnemyTurn(Int32 t)
        {
            EndOfTurnMaintainEnemy();

            Model.CharacterRelated.SkillRelated.Skill sk = 
                _map.Current.Special.Enemies[t].ChooseSkill(_player);

            if (_map.Current.Special.Distances[t] > sk.Range)
            {
                Battle_Content += _map.Current.Special.Enemies[t].Name + 
                    " comes closer to you." + Environment.NewLine;
                OnPropertyChanged("Battle_Content");
                _map.Current.Special.Distances[t] -= 
                    _map.Current.Special.Enemies[t].TotalStats.Speed;
                if (_map.Current.Special.Distances[t] < 0)
                    _map.Current.Special.Distances[t] = 0;
                OnPropertyChanged("Battle_EnemyDistance");
                return;
            }

            _map.Current.Special.Enemies[t].BaseStats.Mana.Consume(sk.ManaCost);
            _map.Current.Special.Enemies[t].Skills.SkillTree.Find(skill => skill == sk).IsOnCooldown = 
                _map.Current.Special.Enemies[t].Skills.SkillTree.Find(skill => skill == sk).Cooldown;
            _map.Current.Special.Enemies[t].ActiveEffects.Add(sk);

            //Add skill stats

            _map.Current.Special.Enemies[t].BaseStats.Attack += sk.AdditionalAttack;
            _map.Current.Special.Enemies[t].BaseStats.Defense += sk.AdditionalDefense;
            _map.Current.Special.Enemies[t].BaseStats.Health.Increase(sk.AdditionalHealth);
            _map.Current.Special.Enemies[t].BaseStats.Health.Heal(sk.Heal);
            _map.Current.Special.Enemies[t].BaseStats.Mana.Increase(sk.AdditionalMana);
            _map.Current.Special.Enemies[t].BaseStats.Mana.Regen(sk.Recover);
            _map.Current.Special.Enemies[t].BaseStats.Speed += sk.AdditionalSpeed;
            Battle_Content += "Enemy: " + sk.UseMessage + Environment.NewLine;
            OnPropertyChanged("Battle_Content");

            //DO damage
            HitPlayer(t);
        }

        private void HitPlayer(Int32 t)
        {
            Int32 actual = _player.TotalStats.Damage(_map.Current.Special.Enemies[t].TotalStats.Attack.Value);
            if (_player.TotalStats.Health.Current <= 0)
            {
                OnGameOver(_map.Current.Special.Enemies[t] + " has killed you in battle!");
                return;
            }

            Battle_Content += _map.Current.Special.Enemies[t].Name + " did " + 
                _map.Current.Special.Enemies[t].TotalStats.Attack.Value.ToString() +
                " damage to you while you blocked " + 
                (_map.Current.Special.Enemies[t].TotalStats.Attack.Value - actual).ToString() +
                " amount, resulting in an actual damage of " + actual.ToString() + "." +
                Environment.NewLine;
            OnPropertyChanged("Battle_Content");
            OnChangePlayer();
            OnChangeEnemy();
        }

        private void EndOfTurnMaintainPlayer()
        {
            foreach (Model.CharacterRelated.SkillRelated.Skill skill in _player.Skills.SkillTree)
            {
                if (_player.ActiveEffects.Contains(skill))
                {
                    --skill.IsOnCooldown;
                    Int32 i = _player.ActiveEffects.IndexOf(skill);
                    if (skill.IsOnCooldown == 0)
                    {
                        _player.ActiveEffects.RemoveAt(i);
                        //remove buffs
                        _player.BaseStats.Attack -= skill.AdditionalAttack;
                        _player.BaseStats.Defense -= skill.AdditionalDefense;
                        _player.BaseStats.Health.Decrease(skill.AdditionalHealth);
                        _player.BaseStats.Mana.Decrease(skill.AdditionalMana);
                        _player.BaseStats.Speed -= skill.AdditionalSpeed;
                        _player.ActiveEffects.RemoveAt(i);
                        OnChangePlayer();
                    }
                }
            }
        }

        private void EndOfTurnMaintainEnemy()
        {
            foreach (Model.CharacterRelated.SkillRelated.Skill skill in _map.Current.Special.Enemies[_target].Skills.SkillTree)
            {
                if (_map.Current.Special.Enemies[_target].ActiveEffects.Contains(skill))
                {
                    --skill.IsOnCooldown;
                    Int32 i = _map.Current.Special.Enemies[_target].ActiveEffects.IndexOf(skill);
                    if (skill.IsOnCooldown == 0)
                    {
                        _map.Current.Special.Enemies[_target].ActiveEffects.RemoveAt(i);
                        //remove buffs
                        _map.Current.Special.Enemies[_target].BaseStats.Attack -= skill.AdditionalAttack;
                        _map.Current.Special.Enemies[_target].BaseStats.Defense -= skill.AdditionalDefense;
                        _map.Current.Special.Enemies[_target].BaseStats.Health.Decrease(skill.AdditionalHealth);
                        _map.Current.Special.Enemies[_target].BaseStats.Mana.Decrease(skill.AdditionalMana);
                        _map.Current.Special.Enemies[_target].BaseStats.Speed -= skill.AdditionalSpeed;
                        _map.Current.Special.Enemies[_target].ActiveEffects.RemoveAt(i);
                        OnChangeEnemy();
                    }
                }
            }
        }

        private void OnChangePlayer()
        {
            OnPropertyChanged("MyHealth");
            OnPropertyChanged("MyMana");
        }

        private void OnChangeEnemy()
        {
            OnPropertyChanged("Battle_EnemyHealth");
            OnPropertyChanged("Battle_EnemyMana");
            OnPropertyChanged("Battle_EnemyDistance");
            OnPropertyChanged("Battle_IsTargetSelected");
            OnPropertyChanged("Battle_IsTargetNotSelected");
        }

    }
}
