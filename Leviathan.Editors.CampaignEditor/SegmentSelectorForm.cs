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
    public partial class SegmentSelectorForm : Form
    {
        private const Int32 MAX_STRING_LENGTH = 20;

        #region Events

        public event EventHandler<Utils.IdEventArgs> GoTo;
        private void OnGoTo(int id)
        {
            if (GoTo != null)
                GoTo(this, new Utils.IdEventArgs(id));
        }

        #endregion Events

        public SegmentSelectorForm()
        {
            InitializeComponent();

            this.Activated += new EventHandler(Update);
            this.GotFocus += new EventHandler(Update);
            this.LostFocus += new EventHandler(Update);

            RefreshView();
        }

        private void RefreshView()
        {
            SegmentListBox.Items.Clear();
            for (int i = 0; i < ResourceManager.Map.Segments.Count; ++i)
            {
                SegmentListBox.Items.Add(createText(i));
            }
        }

        private void Update(object sender, EventArgs e)
        {
            RefreshView();
        }

        private String createText(int id)
        {
            String result = id + ": ";

            int len = (ResourceManager.Map.Segments[id].Content.Length < MAX_STRING_LENGTH ? ResourceManager.Map.Segments[id].Content.Length : MAX_STRING_LENGTH);
            result += ResourceManager.Map.Segments[id].Content.Substring(0, len);

            if (ResourceManager.Map.Segments[id].Content.Length > MAX_STRING_LENGTH)
                result += " ...";

            return result;
        }

        private void SegmentListBox_DoubleClick(object sender, EventArgs e)
        {
            CheckGoTo();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            CheckGoTo();
        }

        private void CheckGoTo()
        {
            if(SegmentListBox.SelectedIndex > -1 && SegmentListBox.SelectedIndex < SegmentListBox.Items.Count)
            {
                OnGoTo(SegmentListBox.SelectedIndex);
            }
        }
    }
}
