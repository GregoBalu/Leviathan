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

            String configFilePath = Environment.CurrentDirectory + "/app.config";
            if (System.IO.File.Exists(configFilePath))
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(configFilePath))
                {
                    _workspaceDir = sr.ReadLine();
                    WorkspaceTextBox.Text = _workspaceDir;
                }
            }
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
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Environment.CurrentDirectory + "/app.config", false))
            {
                sw.WriteLine(_workspaceDir);
            }
        }

        private void CharacterButton_Click(object sender, EventArgs e)
        {
            if (_workspaceDir == null || _workspaceDir == String.Empty)
            {
                MessageBox.Show("First you need to set your workspace to use this function!", "Error");
                return;
            }

            CharacterEditor.MainForm mf = new CharacterEditor.MainForm();
            mf.Ok += new EventHandler(CharacterEditor_Ok);

            mf.ShowDialog();
        }

        private void CharacterEditor_Ok(object sender, EventArgs e)
        {
            CharacterEditor.MainForm mf = (CharacterEditor.MainForm)sender;

            String filepath = _workspaceDir + "/" + mf.Character.Name + ".char";

            if (System.IO.File.Exists(filepath))
            {
                DialogResult dr = MessageBox.Show("Character with that name already exists! Do you want to override the file?", 
                    "Name exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No)
                    return;
            }

            FileHandler.FileHandler.Write(filepath, mf.Character, typeof(Model.CharacterRelated.Character));

            mf.Close();
        }

        private void LoadCharacterButton_Click(object sender, EventArgs e)
        {
            if (_workspaceDir == null || _workspaceDir == String.Empty)
            {
                MessageBox.Show("First you need to set your workspace to use this function!", "Error");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select character to edit";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.InitialDirectory = _workspaceDir;
            ofd.Filter = "Character|*.char";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Model.CharacterRelated.Character ch = FileHandler.FileHandler.Read<Model.CharacterRelated.Character>(ofd.FileName, typeof(Model.CharacterRelated.Character));

                CharacterEditor.MainForm mf = new CharacterEditor.MainForm(ch);
                mf.Ok += new EventHandler(CharacterEditor_Ok);

                mf.ShowDialog();
            }

            
        }
    }
}
