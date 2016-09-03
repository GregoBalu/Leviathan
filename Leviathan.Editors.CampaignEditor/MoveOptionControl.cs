using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leviathan.Model.MapRelated;

namespace Leviathan.Editors.CampaignEditor
{
    public partial class MoveOptionControl : UserControl
    {
        #region Properties

        public Int32 SegmentId { get; private set; }
        public Int32 MoveId { get; private set; }

        #endregion

        #region Events

        public event EventHandler<Utils.IdEventArgs> GoToAction;
        private void OnGoToAction(Int32 id_)
        {
            if (GoToAction != null)
                GoToAction(this, new Utils.IdEventArgs(id_));
        }

        public event EventHandler RemoveAction;
        private void OnRemove()
        {
            if (RemoveAction != null)
                RemoveAction(this, EventArgs.Empty);
        }

        #endregion

        public MoveOptionControl(Int32 segId, Int32 moveId)
        {
            InitializeComponent();

            SegmentId = segId;
            MoveId = moveId;
            TextBox.Text = ResourceManager.Map.Segments[SegmentId].Options[MoveId].Content;
            NumericUpDown.Value = ResourceManager.Map.Segments[SegmentId].Options[MoveId].ToId;

            RefreshView();
        }

        private void RefreshView()
        {
            String toolTipString = "";
            if (ResourceManager.Map.Segments[SegmentId].Options[MoveId].Condition == Condition.Nothing)
                toolTipString = "None.";
            else
            {
                toolTipString = ResourceManager.Map.Segments[SegmentId].Options[MoveId].Condition.Variable + " is " +
                    ResourceManager.Map.Segments[SegmentId].Options[MoveId].Condition.Operator + " to " +
                    ResourceManager.Map.Segments[SegmentId].Options[MoveId].Condition.Value + ".";
            }

            ConditionToolTip.SetToolTip(ConditionButton, toolTipString);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ResourceManager.Map.Segments[SegmentId].Options[MoveId].Content = TextBox.Text;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ResourceManager.Map.Segments[SegmentId].Options[MoveId].ToId = Convert.ToInt32(NumericUpDown.Value);
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            OnGoToAction(ResourceManager.Map.Segments[SegmentId].Options[MoveId].ToId);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            OnRemove();
        }

        private void ConditionButton_Click(object sender, EventArgs e)
        {
            ConditionEditorForm cef = new ConditionEditorForm(ResourceManager.Map.Segments[SegmentId].Options[MoveId].Condition);
            cef.Ok += new EventHandler(Condition_Ok);
            cef.Cancel += new EventHandler(Condition_Ok);
            cef.Show();
            this.Enabled = false;
        }

        private void Condition_Ok(object sender, EventArgs e)
        {
            this.Enabled = true;

            ConditionEditorForm cef = (ConditionEditorForm)sender;
            ResourceManager.Map.Segments[SegmentId].Options[MoveId].Condition = cef.Condition;

            RefreshView();
        }

        private void Condition_Cancel(object sender, EventArgs e)
        {
            this.Enabled = true;
        }
    }
}
