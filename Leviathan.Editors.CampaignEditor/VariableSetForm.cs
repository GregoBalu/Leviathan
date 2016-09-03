using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leviathan.Editors.CampaignEditor
{
    public partial class VariableSetForm : Form
    {

        public Int32 SegmentId { get; private set; }

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

        public VariableSetForm(Int32 segid)
        {
            InitializeComponent();

            SegmentId = segid;

            RefreshView();
        }

        private void RefreshView()
        {
            ValueNumericUpDown.Value = 0;

            VariableComboBox.Items.Clear();
            foreach(String varName in ResourceManager.Map.Variables)
            {
                VariableComboBox.Items.Add(varName);
            }
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ResourceManager.Map.Segments[SegmentId].Special.VariableName = (string)VariableComboBox.SelectedItem;
            ResourceManager.Map.Segments[SegmentId].Special.VariableValue = Convert.ToInt32(ValueNumericUpDown.Value);

            OnOk();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OnCancel();
        }

        private void EditVarsButton_Click(object sender, EventArgs e)
        {
            VariableEditorForm vef = new VariableEditorForm();
            vef.FormClosing += new FormClosingEventHandler(EditVars_Closing);
            vef.Show();

            this.Enabled = false;
        }

        private void EditVars_Closing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;

            RefreshView();
        }
    }
}
