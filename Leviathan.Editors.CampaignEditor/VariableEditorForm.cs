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
    public partial class VariableEditorForm : Form
    {

        public VariableEditorForm()
        {
            InitializeComponent();

            RefreshView();
        }

        private void RefreshView()
        {
            VariableListBox.Items.Clear();
            foreach (String varName in ResourceManager.Map.Variables)
            {
                VariableListBox.Items.Add(varName);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Utils.InputForm inf = new Utils.InputForm("Add new variable", "Enter a new variable name:");
            inf.Ok += new EventHandler<Utils.StringEventArgs>(Input_Ok);
            inf.Cancel += new EventHandler(Input_Cancel);
            inf.Show();

            this.Enabled = false;
        }

        private void Input_Ok(object sender, Utils.StringEventArgs e)
        {
            this.Enabled = true;
            if(ResourceManager.Map.Variables.Contains(e.String))
            {
                MessageBox.Show("Variable name already exists!", "Error");
            }
            else
            {
                ResourceManager.Map.Variables.Add(e.String);
                RefreshView();
            }
        }

        private void Input_Cancel(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ResourceManager.Map.Variables.Remove((string)VariableListBox.SelectedItem);
            RefreshView();
        }
    }
}
