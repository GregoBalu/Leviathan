using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Leviathan.Model.CharacterRelated;

namespace Leviathan.Editors.CharacterEditor
{
    public partial class MainForm : Form
    {

        private Character _char;
        public Character Character
        {
            get
            {
                return _char;
            }
        }

        #region Events

        public event EventHandler Ok;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (Ok != null)
                Ok(this, EventArgs.Empty);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        public MainForm(Character c = null)
        {
            InitializeComponent();

            //Race
            foreach(Race r in RaceManager.getRaces())
            {
                RaceComboBox.Items.Add(r.RaceName);
            }
            //Class
            foreach (Profession p in ProfessionManager.getProfessions())
            {
                ClassComboBox.Items.Add(p.ProfessionName);
            }

            if (c == null)
                _char = new Character();
            else
                _char = c;

            UpdateView();
        }

        private void UpdateView()
        {
            RaceComboBox.SelectedItem = _char.Race;
            ClassComboBox.SelectedItem = _char.Class;
            HealthNumericUpDown.Value = _char.BaseStats.Health.Max;
            ManaNumericUpDown.Value = _char.BaseStats.Mana.Max;
            LevelNumericUpDown.Value = _char.BaseStats.Experience.Level;
            SpeedNumericUpDown.Value = _char.BaseStats.Speed;
            AttackMinNumericUpDown.Value = _char.BaseStats.Attack.Min;
            AttackMaxNumericUpDown.Value = _char.BaseStats.Attack.Max;
            DefenseMinNumericUpDown.Value = _char.BaseStats.Defense.Min;
            DefenseMaxNumericUpDown.Value = _char.BaseStats.Defense.Max;
        }

        private void RaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _char.Race = RaceManager.getRaces()[RaceComboBox.SelectedIndex];
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _char.Class = ProfessionManager.getProfessions()[ClassComboBox.SelectedIndex];
        }

        private void HealthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Health.Max = Convert.ToInt32(HealthNumericUpDown.Value);
            _char.BaseStats.Health.Current = _char.BaseStats.Health.Max;
        }

        private void ManaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Mana.Max = Convert.ToInt32(ManaNumericUpDown.Value);
            _char.BaseStats.Mana.Current = _char.BaseStats.Mana.Max;
        }

        private void SpeedNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Speed = Convert.ToInt32(SpeedNumericUpDown.Value);
        }

        private void AttackMinNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Attack.Min = Convert.ToInt32(AttackMinNumericUpDown.Value);
        }

        private void AttackMaxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Attack.Max = Convert.ToInt32(AttackMaxNumericUpDown.Value);
        }

        private void DefenseMinNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Defense.Min = Convert.ToInt32(DefenseMinNumericUpDown.Value);
        }

        private void DefenseMaxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Defense.Max = Convert.ToInt32(DefenseMaxNumericUpDown.Value);
        }

        private void LevelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _char.BaseStats.Experience.Level = Convert.ToInt32(LevelNumericUpDown.Value);

            int temp = Convert.ToInt32(LevelNumericUpDown.Value);
        }


    }
}
