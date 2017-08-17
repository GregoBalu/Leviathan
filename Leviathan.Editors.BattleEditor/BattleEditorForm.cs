using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Leviathan.Model.MapRelated;
using Leviathan.Model.CharacterRelated;

namespace Leviathan.Editors.BattleEditor
{
    public partial class BattleEditorForm : Form
    {
        private Special _special;
        public Special Special
        {
            get
            {
                return _special;
            }
        }

        #region Events

        public event EventHandler Ok;
        private void OnOk()
        {
            if (Ok != null)
                Ok(this, EventArgs.Empty);
        }

        public event EventHandler Cancel;
        private void OnCancel()
        {
            if (Cancel != null)
                Cancel(this, EventArgs.Empty);
        }

        #endregion

        public BattleEditorForm(Special sp)
        {
            InitializeComponent();

            _special = sp;
            if (_special == null)
                _special = new Special(Model.MapRelated.Specials.SpecialType.Battle);

            PropertiesGroupBox.Visible = false;

            UpdateView();
        }

        private void UpdateView()
        {
            EnemiesListBox.Items.Clear();
            foreach (Character ch in _special.Enemies)
            {
                EnemiesListBox.Items.Add(ch.ToString());
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            OnOk();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OnCancel();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CharacterEditor.MainForm mf = new CharacterEditor.MainForm();
            mf.Ok += new EventHandler(CharacterEditor_Add_Ok);
            mf.FormClosed += new FormClosedEventHandler(CharacterEditor_Closed);
            mf.Show();

            this.Enabled = false;
        }

        private void CharacterEditor_Add_Ok(object sender, EventArgs e)
        {
            this.Enabled = true;
            CharacterEditor.MainForm mf = (CharacterEditor.MainForm)sender;
            
            _special.Enemies.Add(mf.Character);
            _special.Distances.Add(0);

            mf.Close();
            UpdateView();
        }

        private void CharacterEditor_Closed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(EnemiesListBox.SelectedItem != null)
            {
                Int32 i = EnemiesListBox.SelectedIndex;
                _special.Enemies.RemoveAt(i);
                EnemiesListBox.Items.RemoveAt(i);
                _special.Distances.RemoveAt(i);
            }
        }

        private void EnemiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnemiesListBox.SelectedIndex >= 0)
            {
                PropertiesGroupBox.Visible = true;
                DistanceNumericUpDown.Value = _special.Distances[EnemiesListBox.SelectedIndex];
            }
            else
            {
                PropertiesGroupBox.Visible = false;

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EnemiesListBox.SelectedItem != null)
            {
                Character ch = _special.Enemies[EnemiesListBox.SelectedIndex];
                CharacterEditor.MainForm mf = new CharacterEditor.MainForm(ch);
                mf.Ok += new EventHandler(CharacterEditor_Edit_Ok);
                mf.FormClosed += new FormClosedEventHandler(CharacterEditor_Closed);
                mf.Show();

                this.Enabled = false;
            }
        }

        private void CharacterEditor_Edit_Ok(object sender, EventArgs e)
        {
            this.Enabled = true;
            CharacterEditor.MainForm mf = (CharacterEditor.MainForm)sender;
            mf.Close();

            Int32 i = _special.Enemies.IndexOf((Character)EnemiesListBox.SelectedItem);
            _special.Enemies[i] = mf.Character;
            EnemiesListBox.Items[i] = mf.Character.ToString();
        }

        private void DistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _special.Distances[EnemiesListBox.SelectedIndex] = Convert.ToInt32(DistanceNumericUpDown.Value);
        }

    }
}
