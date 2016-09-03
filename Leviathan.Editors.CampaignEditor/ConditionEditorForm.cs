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
using Leviathan.Model.MapRelated.ConditionRelated;

namespace Leviathan.Editors.CampaignEditor
{
    public partial class ConditionEditorForm : Form
    { 

        public Condition Condition
        {
            get
            {
                return new Condition(Variable, Operator, Value);
            }
        }

        public String Variable
        {
            get
            {
                return (String)VariablesComboBox.SelectedItem;
            }
        }

        public Operator Operator
        {
            get
            {
                return (Operator)OperatorComboBox.SelectedItem;
            }
        }

        public Int32 Value
        {
            get
            {
                return Convert.ToInt32(NumericUpDown.Value);
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

        public ConditionEditorForm(Condition cond)
        {
            InitializeComponent();

            VariablesComboBox.Items.Clear();
            foreach(String v in ResourceManager.Map.Variables)
            {
                VariablesComboBox.Items.Add(v);
            }
            VariablesComboBox.SelectedItem = cond.Variable;

            OperatorComboBox.Items.Clear();
            foreach(Operator o in Enum.GetValues(typeof(Operator)))
            {
                OperatorComboBox.Items.Add(o);
            }
            OperatorComboBox.SelectedItem = cond.Operator;

            NumericUpDown.Value = cond.Value;
        }

        private void VariablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OperatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            VariableEditorForm vef = new VariableEditorForm();
            vef.FormClosing += new FormClosingEventHandler(Variable_Closing);
            vef.Show();

            this.Enabled = false;
        }

        private void Variable_Closing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;

            VariableEditorForm vef = (VariableEditorForm)sender;
            

            VariablesComboBox.Items.Clear();
            foreach (String v in ResourceManager.Map.Variables)
            {
                VariablesComboBox.Items.Add(v);
            }
            VariablesComboBox.SelectedIndex = VariablesComboBox.Items.Count - 1;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            OnOk();
            this.Close();
        }

        private void ConditionEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCancel();
        }
    }
}
