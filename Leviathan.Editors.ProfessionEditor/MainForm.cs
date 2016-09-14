using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leviathan.Editors.ProfessionEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Model.CharacterRelated.ProfessionManager.loadProfessions();

            PropertiesGroupBox.Visible = false;

            ProfessionListBox.Items.Clear();
            foreach(String key in Model.CharacterRelated.ProfessionManager.Professions.Keys)
            {
                ProfessionListBox.Items.Add(key);
            }
        }

        private void ShowProperties()
        {
            PropertiesGroupBox.Visible = true;

            Model.CharacterRelated.ProfessionManager.ProfessionInfo pi = Model.CharacterRelated.ProfessionManager.Professions[(String)ProfessionListBox.SelectedItem];

            HealthSetter.Value = pi.Start.Health.Max;
            ManaSetter.Value = pi.Start.Mana.Max;
            AttackMinSetter.Value = pi.Start.Attack.Min;
            AttackMaxSetter.Value = pi.Start.Attack.Max;
            DefenseMinSetter.Value = pi.Start.Defense.Min;
            DefenseMaxSetter.Value = pi.Start.Defense.Max;
            SpeedSetter.Value = pi.Start.Speed;

            LHealthSetter.Value = pi.LevelUp.Health.Max;
            LManaSetter.Value = pi.LevelUp.Mana.Max;
            LAttackMinSetter.Value = pi.LevelUp.Attack.Min;
            LAttackMaxSetter.Value = pi.LevelUp.Attack.Max;
            LDefenseMinSetter.Value = pi.LevelUp.Defense.Min;
            LDefenseMaxSetter.Value = pi.LevelUp.Defense.Max;
            LSpeedSetter.Value = pi.LevelUp.Speed;

            SkillListBox.Items.Clear();
            foreach(Model.CharacterRelated.SkillRelated.Skill sk in pi.SkillTree)
            {
                SkillListBox.Items.Add(sk.DisplayName);
            }
        }

        private void AddProfessionButton_Click(object sender, EventArgs e)
        {
            Utils.InputForm inp = new Utils.InputForm("New Profession Name", "Add the new profession's name:");
            inp.Ok += new EventHandler<Utils.StringEventArgs>(AddProfession_Ok);
            inp.Cancel += new EventHandler((s_, e_) => { } );
            inp.ShowDialog();
        }

        private void AddProfession_Ok(object sender, Utils.StringEventArgs e)
        {
            Model.CharacterRelated.ProfessionManager.Professions.Add(e.String, new Model.CharacterRelated.ProfessionManager.ProfessionInfo());

            ProfessionListBox.Items.Add(e.String);
            ProfessionListBox.SelectedItem = e.String;
        }

        private void RemoveProfessionButton_Click(object sender, EventArgs e)
        {
            if(IsValidIndex())
            {
                String toRemove = (String)ProfessionListBox.SelectedItem;
                ProfessionListBox.Items.RemoveAt(ProfessionListBox.SelectedIndex);
                PropertiesGroupBox.Visible = false;

                Model.CharacterRelated.ProfessionManager.Professions.Remove(toRemove);
            }
        }

        private void ProfessionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IsValidIndex())
                ShowProperties();
        }

        private bool IsValidIndex()
        {
            return ProfessionListBox.SelectedIndex > -1 && ProfessionListBox.SelectedIndex < ProfessionListBox.Items.Count;
        }

        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            Model.CharacterRelated.ProfessionManager.ProfessionInfo ri =
                Model.CharacterRelated.ProfessionManager.Professions[(String)ProfessionListBox.SelectedItem];
            ri.SkillTree.Add(new Model.CharacterRelated.SkillRelated.Skill());
            SkillListBox.Items.Add("NEW");
            SkillListBox.SelectedIndex = SkillListBox.Items.Count - 1;

            SetupSkillEditor();
        }

        private void SkillListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetupSkillEditor();
        }

        private void SetupSkillEditor()
        {
            if (SkillListBox.SelectedIndex >= 0 &&
                SkillListBox.SelectedIndex < SkillListBox.Items.Count)
            {
                Model.CharacterRelated.ProfessionManager.ProfessionInfo ri =
                    Model.CharacterRelated.ProfessionManager.Professions[(String)ProfessionListBox.SelectedItem];

                SkillEditorForm sef = new SkillEditorForm(ri.SkillTree[SkillListBox.SelectedIndex]);

                //TODO
            }
        }

        private void RemoveSkillButton_Click(object sender, EventArgs e)
        {
            if(SkillListBox.SelectedIndex > -1 && SkillListBox.SelectedIndex < SkillListBox.Items.Count)
            {
                Int32 toRemove = SkillListBox.SelectedIndex;
                SkillListBox.Items.RemoveAt(toRemove);

                Model.CharacterRelated.ProfessionManager.Professions[(String)ProfessionListBox.SelectedItem].SkillTree.RemoveAt(toRemove);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            Model.CharacterRelated.ProfessionManager.saveProfessions();
        }

        private void Stats_ValueChanged(object sender, EventArgs e)
        {
            Model.CharacterRelated.ProfessionManager.ProfessionInfo ri = 
                Model.CharacterRelated.ProfessionManager.Professions[(String)ProfessionListBox.SelectedItem];

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

        private void UpSkillButton_Click(object sender, EventArgs e)
        {
            SwapSkills(-1);
        }

        private void DownSkillButton_Click(object sender, EventArgs e)
        {
            SwapSkills(1);
        }

        private Boolean SwapSkills(int mod)
        {
            Model.CharacterRelated.ProfessionManager.ProfessionInfo ri =
                Model.CharacterRelated.ProfessionManager.Professions[(String)ProfessionListBox.SelectedItem];

            if (SkillListBox.SelectedIndex >= 0 &&
                SkillListBox.SelectedIndex + mod >= 0 && 
                SkillListBox.SelectedIndex < ri.SkillTree.Count &&
                SkillListBox.SelectedIndex + mod < ri.SkillTree.Count)
            {
                int i = SkillListBox.SelectedIndex;

                Model.CharacterRelated.SkillRelated.Skill temp = ri.SkillTree[i + mod];
                ri.SkillTree[i + mod] = ri.SkillTree[i];
                ri.SkillTree[i] = temp;

                return true;
            }

            return false;
        }

    }
}
