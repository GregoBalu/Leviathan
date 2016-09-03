namespace Leviathan.Editors.CampaignEditor
{
    partial class VariableSetForm
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
            this.VariableComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EditVarsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // VariableComboBox
            // 
            this.VariableComboBox.FormattingEnabled = true;
            this.VariableComboBox.Location = new System.Drawing.Point(12, 12);
            this.VariableComboBox.Name = "VariableComboBox";
            this.VariableComboBox.Size = new System.Drawing.Size(131, 21);
            this.VariableComboBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(198, 46);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(12, 46);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // ValueNumericUpDown
            // 
            this.ValueNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueNumericUpDown.Location = new System.Drawing.Point(168, 13);
            this.ValueNumericUpDown.Name = "ValueNumericUpDown";
            this.ValueNumericUpDown.Size = new System.Drawing.Size(105, 20);
            this.ValueNumericUpDown.TabIndex = 7;
            // 
            // EditVarsButton
            // 
            this.EditVarsButton.Location = new System.Drawing.Point(105, 46);
            this.EditVarsButton.Name = "EditVarsButton";
            this.EditVarsButton.Size = new System.Drawing.Size(75, 23);
            this.EditVarsButton.TabIndex = 8;
            this.EditVarsButton.Text = "Edit Vars";
            this.EditVarsButton.UseVisualStyleBackColor = true;
            this.EditVarsButton.Click += new System.EventHandler(this.EditVarsButton_Click);
            // 
            // VariableSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 81);
            this.Controls.Add(this.EditVarsButton);
            this.Controls.Add(this.ValueNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.VariableComboBox);
            this.MaximumSize = new System.Drawing.Size(301, 120);
            this.MinimumSize = new System.Drawing.Size(301, 120);
            this.Name = "VariableSetForm";
            this.Text = "VariableSetForm";
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VariableComboBox;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ValueNumericUpDown;
        private System.Windows.Forms.Button EditVarsButton;
    }
}