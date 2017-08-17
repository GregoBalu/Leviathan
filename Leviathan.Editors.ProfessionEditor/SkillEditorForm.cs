using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leviathan.Model.CharacterRelated.SkillRelated;
using Leviathan.Editors.Utils;

namespace Leviathan.Editors.ProfessionEditor
{
    public partial class SkillEditorForm : Form
    {

        private Skill _skill;
        private bool _dontSave;

        #region Events

        public event EventHandler<SkillEventArgs> Ok;
        private void OnOk(Skill sk)
        {
            if (Ok != null)
                Ok(this, new SkillEventArgs(sk));
        }

        public event EventHandler Cancel;
        private void OnCancel()
        {
            if (Cancel != null)
                Cancel(this, EventArgs.Empty);
        }

        #endregion

        public SkillEditorForm(Skill def = null)
        {
            InitializeComponent();

            _dontSave = true;

            if (def != null)
                _skill = def;
            else
                _skill = new Skill();

            UpdateView();

            _dontSave = false;
        }

        private void SkillEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save this skill before closing the window?",
                "Save or not", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                OnOk(_skill);
        }

        private void UpdateView()
        {
            _dontSave = true;

            DisplayNameTextBox.Text = _skill.DisplayName;
            ToolTipTextBox.Text = _skill.ToolTip;
            UseMessageTextBox.Text = _skill.UseMessage;

            LevelReqNnumericUpDown.Value = _skill.LevelRequired;
            CooldownNumericUpDown.Value = _skill.Cooldown;
            ManaCostNumericUpDown.Value = _skill.ManaCost;
            RangeNumericUpDown.Value = _skill.Range;
            DurationNumericUpDown.Value = _skill.Duration;
            IsUnlockedCheckBox.Checked = _skill.IsUnlocked;

            if (_skill.ImageName == null || _skill.ImageName == "")
                ImagePictureBox.Hide();
            else
            {
                ImagePictureBox.Image = Utils.ImageHandler.Base64ToImage(_skill.ImageName);
                ImagePictureBox.Show();
            }

            _dontSave = false;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            if (_dontSave)
                return;

            _skill.DisplayName = DisplayNameTextBox.Text;
            _skill.ToolTip = ToolTipTextBox.Text;
            _skill.UseMessage = UseMessageTextBox.Text;

            _skill.LevelRequired = Convert.ToInt32(LevelReqNnumericUpDown.Value);
            _skill.Cooldown = Convert.ToInt32(CooldownNumericUpDown.Value);
            _skill.ManaCost = Convert.ToInt32(ManaCostNumericUpDown.Value);
            _skill.Range = Convert.ToInt32(RangeNumericUpDown.Value);
            _skill.Duration = Convert.ToInt32(DurationNumericUpDown.Value);
            _skill.IsUnlocked = IsUnlockedCheckBox.Checked;

        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (ImageButton.Text == "Add")
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Title = "Select image";
                ofd.Multiselect = false;
                ofd.CheckFileExists = true;

                DialogResult dr = ofd.ShowDialog();

                if (dr != DialogResult.OK)
                    return;

                Image img = Image.FromFile(ofd.FileName);

                _skill.ImageName = Utils.ImageHandler.ImageToBase64(img, System.Drawing.Imaging.ImageFormat.Png);
;
                ImageButton.Text = "Remove";
            }
            else
            {
                _skill.ImageName = String.Empty;

                ImageButton.Text = "Add";
            }

            UpdateView();
        }
    }
}
