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
        }
    }
}
