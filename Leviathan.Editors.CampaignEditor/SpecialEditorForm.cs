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
using Leviathan.Model.MapRelated.Specials;

namespace Leviathan.Editors.CampaignEditor
{
    public partial class SpecialEditorForm : Form
    {
        public Int32 SegmentId;

        public SpecialEditorForm(Int32 segid)
        {
            InitializeComponent();

            SegmentId = segid;

            TypeComboBox.Items.Clear();
            foreach (SpecialType t in Enum.GetValues(typeof(SpecialType)))
            {
                TypeComboBox.Items.Add(t);
            }

            if (ResourceManager.Map.Segments[SegmentId].Special == null)
                ResourceManager.Map.Segments[SegmentId].Special = new Special();

            TypeComboBox.SelectedItem = ResourceManager.Map.Segments[SegmentId].Special.Type;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            switch ((SpecialType)TypeComboBox.SelectedItem)
            {
                case SpecialType.None:
                    break;
                case SpecialType.Battle:
                    ResourceManager.Map.Segments[SegmentId].Special.Type = SpecialType.Battle;
                    Leviathan.Editors.BattleEditor.BattleEditorForm bef = new BattleEditor.BattleEditorForm(ResourceManager.Map.Segments[SegmentId].Special);
                    bef.Ok += new EventHandler(BattleEditor_Ok);
                    bef.Cancel += new EventHandler(BattleEditor_Cancel);
                    bef.FormClosed += new FormClosedEventHandler(BattleEditor_Closed);
                    bef.Show();
                    break;
                case SpecialType.Puzzle:
                    throw new NotImplementedException();
                case SpecialType.Conversation:
                    throw new NotImplementedException();
                case SpecialType.VariableSet:
                    ResourceManager.Map.Segments[SegmentId].Special.Type = SpecialType.VariableSet;
                    VariableSetForm vsf = new VariableSetForm(SegmentId);
                    vsf.Ok += new EventHandler(VariableSet_Ok);
                    vsf.Cancel += new EventHandler(VariableSet_Cancel);
                    vsf.FormClosed += new FormClosedEventHandler(VariableSet_Closed);
                    vsf.Show();
                    break;
            }
            ResourceManager.Map.Segments[SegmentId].Special = ResourceManager.Map.Segments[SegmentId].Special;
            this.Enabled = false;
        }

        private void BattleEditor_Ok(object sender, EventArgs e)
        {
            Leviathan.Editors.BattleEditor.BattleEditorForm bef = (Leviathan.Editors.BattleEditor.BattleEditorForm)sender;

            ResourceManager.Map.Segments[SegmentId].Special = bef.Special;
            bef.Close();

            this.Close();
        }

        private void BattleEditor_Cancel(object sender, EventArgs e)
        {
            Leviathan.Editors.BattleEditor.BattleEditorForm bef = (Leviathan.Editors.BattleEditor.BattleEditorForm)sender;

            bef.Close();

            this.Close();
        }

        private void BattleEditor_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void VariableSet_Ok(object sender, EventArgs e)
        {
            VariableSetForm vsf = (VariableSetForm)sender;

            vsf.Close();
            this.Close();
        }

        private void VariableSet_Cancel(object sender, EventArgs e)
        {
            VariableSetForm vsf = (VariableSetForm)sender;

            vsf.Close();
            this.Close();
        }

        private void VariableSet_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
