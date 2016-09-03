namespace Leviathan.Editors.CampaignEditor
{
    partial class SegmentSelectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SegmentListBox = new System.Windows.Forms.ListBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SegmentListBox
            // 
            this.SegmentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SegmentListBox.FormattingEnabled = true;
            this.SegmentListBox.Location = new System.Drawing.Point(12, 12);
            this.SegmentListBox.Name = "SegmentListBox";
            this.SegmentListBox.Size = new System.Drawing.Size(185, 329);
            this.SegmentListBox.TabIndex = 0;
            this.SegmentListBox.DoubleClick += new System.EventHandler(this.SegmentListBox_DoubleClick);
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Location = new System.Drawing.Point(12, 362);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(185, 31);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SegmentSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 405);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.SegmentListBox);
            this.MinimumSize = new System.Drawing.Size(150, 160);
            this.Name = "SegmentSelectorForm";
            this.Text = "Segment Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SegmentListBox;
        private System.Windows.Forms.Button GoButton;
    }
}