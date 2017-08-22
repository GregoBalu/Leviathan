namespace Leviathan.Editors.Frame
{
    partial class MainForm
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
            this.CampaignButton = new System.Windows.Forms.Button();
            this.RaceButton = new System.Windows.Forms.Button();
            this.ClassButton = new System.Windows.Forms.Button();
            this.WorkspaceTextBox = new System.Windows.Forms.TextBox();
            this.ChangeWorkspaceButton = new System.Windows.Forms.Button();
            this.CharacterButton = new System.Windows.Forms.Button();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CampaignButton
            // 
            this.CampaignButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignButton.Location = new System.Drawing.Point(12, 12);
            this.CampaignButton.Name = "CampaignButton";
            this.CampaignButton.Size = new System.Drawing.Size(220, 30);
            this.CampaignButton.TabIndex = 0;
            this.CampaignButton.Text = "Campaign Editor";
            this.CampaignButton.UseVisualStyleBackColor = true;
            this.CampaignButton.Click += new System.EventHandler(this.CampaignButton_Click);
            // 
            // RaceButton
            // 
            this.RaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RaceButton.Location = new System.Drawing.Point(12, 48);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(220, 30);
            this.RaceButton.TabIndex = 1;
            this.RaceButton.Text = "Race Editor";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // ClassButton
            // 
            this.ClassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassButton.Location = new System.Drawing.Point(12, 84);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(220, 30);
            this.ClassButton.TabIndex = 2;
            this.ClassButton.Text = "Class Editor";
            this.ClassButton.UseVisualStyleBackColor = true;
            this.ClassButton.Click += new System.EventHandler(this.ClassButton_Click);
            // 
            // WorkspaceTextBox
            // 
            this.WorkspaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkspaceTextBox.Enabled = false;
            this.WorkspaceTextBox.Location = new System.Drawing.Point(12, 229);
            this.WorkspaceTextBox.Name = "WorkspaceTextBox";
            this.WorkspaceTextBox.Size = new System.Drawing.Size(220, 20);
            this.WorkspaceTextBox.TabIndex = 3;
            // 
            // ChangeWorkspaceButton
            // 
            this.ChangeWorkspaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeWorkspaceButton.Location = new System.Drawing.Point(12, 200);
            this.ChangeWorkspaceButton.Name = "ChangeWorkspaceButton";
            this.ChangeWorkspaceButton.Size = new System.Drawing.Size(115, 23);
            this.ChangeWorkspaceButton.TabIndex = 4;
            this.ChangeWorkspaceButton.Text = "Change Workspace";
            this.ChangeWorkspaceButton.UseVisualStyleBackColor = true;
            this.ChangeWorkspaceButton.Click += new System.EventHandler(this.ChangeWorkspaceButton_Click);
            // 
            // CharacterButton
            // 
            this.CharacterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterButton.Location = new System.Drawing.Point(3, 3);
            this.CharacterButton.Name = "CharacterButton";
            this.CharacterButton.Size = new System.Drawing.Size(141, 30);
            this.CharacterButton.TabIndex = 5;
            this.CharacterButton.Text = "Character Editor";
            this.CharacterButton.UseVisualStyleBackColor = true;
            this.CharacterButton.Click += new System.EventHandler(this.CharacterButton_Click);
            // 
            // LoadCharacterButton
            // 
            this.LoadCharacterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadCharacterButton.Location = new System.Drawing.Point(3, 3);
            this.LoadCharacterButton.Name = "LoadCharacterButton";
            this.LoadCharacterButton.Size = new System.Drawing.Size(63, 30);
            this.LoadCharacterButton.TabIndex = 6;
            this.LoadCharacterButton.Text = "Load";
            this.LoadCharacterButton.UseVisualStyleBackColor = true;
            this.LoadCharacterButton.Click += new System.EventHandler(this.LoadCharacterButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 120);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CharacterButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LoadCharacterButton);
            this.splitContainer1.Size = new System.Drawing.Size(220, 36);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 261);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ChangeWorkspaceButton);
            this.Controls.Add(this.WorkspaceTextBox);
            this.Controls.Add(this.ClassButton);
            this.Controls.Add(this.RaceButton);
            this.Controls.Add(this.CampaignButton);
            this.MinimumSize = new System.Drawing.Size(260, 300);
            this.Name = "MainForm";
            this.Text = "Leviathan Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CampaignButton;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.Button ClassButton;
        private System.Windows.Forms.TextBox WorkspaceTextBox;
        private System.Windows.Forms.Button ChangeWorkspaceButton;
        private System.Windows.Forms.Button CharacterButton;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

