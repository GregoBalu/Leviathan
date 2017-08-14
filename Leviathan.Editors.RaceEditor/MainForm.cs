using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leviathan.Editors.RaceEditor
{
    public partial class MainForm : Form
    {
        private bool _dontSave;

        public MainForm()
        {
            InitializeComponent();

            _dontSave = true;

            Model.CharacterRelated.RaceManager.loadRaces();

            PropertiesGroupBox.Visible = false;

            RaceListBox.Items.Clear();
            foreach(String key in Model.CharacterRelated.RaceManager.Races.Keys)
            {
                RaceListBox.Items.Add(key);
            }

            if (RaceListBox.Items.Count > 0)
                RaceListBox.SelectedIndex = 0;

            _dontSave = false;
        }

        private void ShowProperties()
        {
            PropertiesGroupBox.Visible = true;

            _dontSave = true;

            Model.CharacterRelated.RaceManager.RaceInfo ri = Model.CharacterRelated.RaceManager.Races[(String)RaceListBox.SelectedItem];

            HealthSetter.Value = ri.Start.Health.Max;
            ManaSetter.Value = ri.Start.Mana.Max;
            AttackMinSetter.Value = ri.Start.Attack.Min;
            AttackMaxSetter.Value = ri.Start.Attack.Max;
            DefenseMinSetter.Value = ri.Start.Defense.Min;
            DefenseMaxSetter.Value = ri.Start.Defense.Max;
            SpeedSetter.Value = ri.Start.Speed;

            LHealthSetter.Value = ri.LevelUp.Health.Max;
            LManaSetter.Value = ri.LevelUp.Mana.Max;
            LAttackMinSetter.Value = ri.LevelUp.Attack.Min;
            LAttackMaxSetter.Value = ri.LevelUp.Attack.Max;
            LDefenseMinSetter.Value = ri.LevelUp.Defense.Min;
            LDefenseMaxSetter.Value = ri.LevelUp.Defense.Max;
            LSpeedSetter.Value = ri.LevelUp.Speed;

            ZonesListBox.Items.Clear();
            foreach(String zone in ri.StartZones)
            {
                ZonesListBox.Items.Add(zone);
            }

            _dontSave = false;
        }

        private void AddRaceButton_Click(object sender, EventArgs e)
        {
            Utils.InputForm inp = new Utils.InputForm("New Race Name", "Add the new race's name:");
            inp.Ok += new EventHandler<Utils.StringEventArgs>(AddRace_Ok);
            inp.Cancel += new EventHandler((s_, e_) => { } );
            inp.ShowDialog();
        }

        private void AddRace_Ok(object sender, Utils.StringEventArgs e)
        {
            Model.CharacterRelated.RaceManager.Races.Add(e.String, new Model.CharacterRelated.RaceManager.RaceInfo());

            RaceListBox.Items.Add(e.String);
            RaceListBox.SelectedItem = e.String;
        }

        private void RemoveRaceButton_Click(object sender, EventArgs e)
        {
            if(IsValidIndex())
            {
                String toRemove = (String)RaceListBox.SelectedItem;
                RaceListBox.Items.RemoveAt(RaceListBox.SelectedIndex);
                PropertiesGroupBox.Visible = false;

                Model.CharacterRelated.RaceManager.Races.Remove(toRemove);
            }
        }

        private void RaceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IsValidIndex())
                ShowProperties();
        }

        private bool IsValidIndex()
        {
            return RaceListBox.SelectedIndex >= 0 && RaceListBox.SelectedIndex < RaceListBox.Items.Count;
        }

        private void AddZoneButton_Click(object sender, EventArgs e)
        {
            Utils.InputForm inp = new Utils.InputForm("New Zone", "Add the zone's name:");
            inp.Ok += new EventHandler<Utils.StringEventArgs>(AddZone_Ok);
            inp.Cancel += new EventHandler((s_, e_) => { });
            inp.ShowDialog();
        }

        private void AddZone_Ok(object sender, Utils.StringEventArgs e)
        {
            Model.CharacterRelated.RaceManager.Races[(String)RaceListBox.SelectedItem].StartZones.Add(e.String);

            ZonesListBox.Items.Add(e.String);
            ZonesListBox.SelectedItem = e.String;
        }

        private void RemoveZoneButton_Click(object sender, EventArgs e)
        {
            if(ZonesListBox.SelectedIndex > -1 && ZonesListBox.SelectedIndex < ZonesListBox.Items.Count)
            {
                String toRemove = (String)ZonesListBox.SelectedItem;
                ZonesListBox.Items.Remove(toRemove);

                Model.CharacterRelated.RaceManager.Races[(String)RaceListBox.SelectedItem].StartZones.Remove(toRemove);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            Model.CharacterRelated.RaceManager.saveRaces();
        }

        private void Stats_ValueChanged(object sender, EventArgs e)
        {
            if (_dontSave)
                return;

            Model.CharacterRelated.RaceManager.RaceInfo ri = Model.CharacterRelated.RaceManager.Races[(String)RaceListBox.SelectedItem];

            ri.Start.Health.Current = ri.Start.Health.Max = Convert.ToInt32(HealthSetter.Value);
            ri.Start.Mana.Current = ri.Start.Mana.Max = Convert.ToInt32(ManaSetter.Value);
            ri.Start.Attack.Min = Convert.ToInt32(AttackMinSetter.Value);
            ri.Start.Attack.Max = Convert.ToInt32(AttackMaxSetter.Value);
            ri.Start.Defense.Min = Convert.ToInt32(DefenseMinSetter.Value);
            ri.Start.Defense.Max = Convert.ToInt32(DefenseMaxSetter.Value);
            ri.Start.Speed = Convert.ToInt32(SpeedSetter.Value);

            ri.LevelUp.Health.Max = Convert.ToInt32(LHealthSetter.Value);
            ri.LevelUp.Mana.Max = Convert.ToInt32(LManaSetter.Value);
            ri.LevelUp.Attack.Min = Convert.ToInt32(LAttackMinSetter.Value);
            ri.LevelUp.Attack.Max = Convert.ToInt32(LAttackMaxSetter.Value);
            ri.LevelUp.Defense.Min = Convert.ToInt32(LDefenseMinSetter.Value);
            ri.LevelUp.Defense.Max = Convert.ToInt32(LDefenseMaxSetter.Value);
            ri.LevelUp.Speed = Convert.ToInt32(LSpeedSetter.Value);

            ri.StartZones = ZonesListBox.Items.Cast<String>().ToList();
        }

        private void AttackMinSetter_Validating(object sender, CancelEventArgs e)
        {
            if(AttackMinSetter.Value > AttackMaxSetter.Value)
            {
                ErrorProvider.SetError(AttackMinSetter, "Min value should not be bigger than Max value.");
                e.Cancel = true;
            }
        }

        private void AttackMaxSetter_Validating(object sender, CancelEventArgs e)
        {
            if (AttackMinSetter.Value > AttackMaxSetter.Value)
            {
                ErrorProvider.SetError(AttackMaxSetter, "Max value should be bigger (or equal) than Min value");
                e.Cancel = true;
            }
        }

        private void DefenseMinSetter_Validating(object sender, CancelEventArgs e)
        {
            if (DefenseMinSetter.Value > DefenseMaxSetter.Value)
            {
                ErrorProvider.SetError(DefenseMinSetter, "Min value should not be bigger than Max value.");
                e.Cancel = true;
            }
        }

        private void DefenseMaxSetter_Validating(object sender, CancelEventArgs e)
        {
            if (DefenseMinSetter.Value > DefenseMaxSetter.Value)
            {
                ErrorProvider.SetError(DefenseMaxSetter, "Max value should be bigger (or equal) than Min value");
                e.Cancel = true;
            }
        }

        private void RangeSetter_Validated(object sender, EventArgs e)
        {
            ErrorProvider.SetError((Control)sender, "");
        }
    }
}
