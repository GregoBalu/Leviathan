using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Leviathan.Model.MapRelated;

namespace Leviathan.Editors.CampaignEditor
{
    public partial class MainForm : Form
    {
        private const Int32 SEGMENT_WIDTH = 160;
        private const Int32 SEGMENT_HEIGHT = 160;

        private String _savePath;

        private Int32 _cur;
        private Int32 _current
        {
            get
            {
                return _cur;
            }
            set
            {
                if(value != _cur)
                {
                    _history.Push(_cur);
                    _cur = value;
                }
            }
        }

        private Stack<Int32> _history;

        #region Events

        public event EventHandler Ok;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (Ok != null)
                Ok(this, EventArgs.Empty);

            SaveMap();
        }

        public event EventHandler Cancel;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (Cancel != null)
                Cancel(this, EventArgs.Empty);

            this.Close();
        }

        #endregion

        public MainForm(Map m = null)
        {
            InitializeComponent();

            if (m == null)
                ResourceManager.Map = new Map(true);
            else
                ResourceManager.Map = m;

            Initialize();
        }

        private void Initialize()
        {
            _history = new Stack<int>();
            _cur = 0;
            _savePath = "";

            UpdateView();
        }

        private void UpdateView()
        {
            ContentTextBox.Text = ResourceManager.Map.Segments[_current].Content;
            PictureBox.ImageLocation = ResourceManager.Map.Segments[_current].ImageName;
            SegmentNumericUpDown.Value = _current;

            if(ResourceManager.Map.Segments[_current].IsSpecial 
                && ResourceManager.Map.Segments[_current].Options.Count != 1)
            {
                OptionsPanel.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                OptionsPanel.BackColor = System.Drawing.Color.White;
            }

            OptionsPanel.Controls.Clear();
            for (Int32 i = 0; i < ResourceManager.Map.Segments[_current].Options.Count; ++i)
            {
                MoveOptionControl moc = new MoveOptionControl(_current, i);
                moc.GoToAction += new EventHandler<Utils.IdEventArgs>(MoveOption_GoToAction);
                moc.RemoveAction += new EventHandler(MoveOption_RemoveAction);

                moc.Location = new System.Drawing.Point(0, 10 + i * moc.Height + moc.Margin.Top);

                OptionsPanel.Controls.Add(moc);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (_history.Count != 0)
            {
                _cur = _history.Pop();
                UpdateView();
            }
        }

        private void SegmentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int32 temp = Convert.ToInt32(SegmentNumericUpDown.Value);
            if (ResourceManager.Map.Segments.Count <= temp)
            {
                do
                {
                    ResourceManager.Map.Segments.Add(new Segment());
                } while (ResourceManager.Map.Segments.Count <= temp);
            }

            _current = temp;
            UpdateView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Int32 nextId = ResourceManager.Map.Segments.Count;
            ResourceManager.Map.Segments[_current].Options.Add(new MoveOption("", nextId));

            UpdateView();
        }

        private void MoveOption_GoToAction(object sender, Utils.IdEventArgs e)
        {
            MoveOptionControl moc = (MoveOptionControl)sender;
            if(ResourceManager.Map.Segments.Count <= e.Id)
            {
                do{
                    ResourceManager.Map.Segments.Add(new Segment());
                } while (ResourceManager.Map.Segments.Count <= e.Id);
            }

            _current = e.Id;
            UpdateView();
        }

        private void MoveOption_RemoveAction(object sender, EventArgs e)
        {
            MoveOptionControl moc = (MoveOptionControl)sender;
            ResourceManager.Map.Segments[_current].Options.RemoveAt(moc.MoveId);

            UpdateView();
        }

        private void ContentTextBox_TextChanged(object sender, EventArgs e)
        {
            ResourceManager.Map.Segments[_current].Content = ContentTextBox.Text;
        }

        private void SpecialButton_Click(object sender, EventArgs e)
        {
            SpecialEditorForm sef = new SpecialEditorForm(_current);
            sef.FormClosed += new FormClosedEventHandler(Special_Closed);
            sef.Show();
            this.Enabled = false;
        }

        private void Special_Closed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            UpdateView();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResourceManager.Map != null)
            {
                DialogResult dr = MessageBox.Show("Do you want to save first?", "Warning!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    SaveMap();
                }
            }

            ResourceManager.Map = new Map(true);
            Initialize();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMap();
        }

        private void LoadMap()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Load Campaign...";
            ofd.Multiselect = false;

            DialogResult dr = ofd.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            _savePath = ofd.FileName;
            _history.Clear();
            _cur = 0;

            try
            {
                ResourceManager.Map = FileHandler.FileHandler.Read<Map>(_savePath, typeof(Map));
            }
            catch(FileHandler.Exceptions.ReadException ex)
            {
                DialogResult continueResult =
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            UpdateView();

            MessageBox.Show("Map loaded successfully!", "Loaded!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMap();
        }

        private void SaveMap()
        {
            if (_savePath == null || _savePath == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save Campaign...";
                
                DialogResult dr = sfd.ShowDialog();
                if (dr != DialogResult.OK)
                    return;

                _savePath = sfd.FileName;
            }

            FileHandler.FileHandler.Write(_savePath, ResourceManager.Map, typeof(Map));

            MessageBox.Show("Map saved successfully!", "Saved!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campaign Editor for Leviathan RPG Game\r\n" +
                "\r\n" +
                "Created by: Balázs Gregorics, 2015-2016", "Credits");
        }

        private void SegmentSelectorButton_Click(object sender, EventArgs e)
        {
            SegmentSelectorForm ssf = new SegmentSelectorForm();
            ssf.GoTo += new EventHandler<Utils.IdEventArgs>(SegmentSelector_Navigate);
            ssf.FormClosed += new FormClosedEventHandler(SegmentSelector_Closed);
            
            ssf.Show();

            ssf.Location = new System.Drawing.Point(this.Location.X + 5 + this.Width, 
                this.Location.Y);
            ssf.Height = this.Height;

            SegmentSelectorButton.Enabled = false;
        }

        private void SegmentSelector_Navigate(object sender, Utils.IdEventArgs e)
        {
            _current = e.Id;
            UpdateView();
        }

        private void SegmentSelector_Closed(object sender, FormClosedEventArgs e)
        {
            SegmentSelectorButton.Enabled = true;
        }
    }
}
