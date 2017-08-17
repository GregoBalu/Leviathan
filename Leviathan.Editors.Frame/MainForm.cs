using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leviathan.Editors.Frame
{
    public partial class MainForm : Form
    {
        private String _workspaceDir;

        public MainForm()
        {
            InitializeComponent();

            WorkspaceTextBox.Text = "None...";
        }

        private void CampaignButton_Click(object sender, EventArgs e)
        {
            CampaignEditor.MainForm mf = new CampaignEditor.MainForm();
            mf.ShowDialog();
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            RaceEditor.MainForm mf = new RaceEditor.MainForm();
            mf.ShowDialog();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            ProfessionEditor.MainForm mf = new ProfessionEditor.MainForm();
            mf.ShowDialog();
        }

        private void ChangeWorkspaceButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select workspace directory";
            DialogResult dr = fbd.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            _workspaceDir = fbd.SelectedPath;
            WorkspaceTextBox.Text = _workspaceDir;
        }
    }
}
