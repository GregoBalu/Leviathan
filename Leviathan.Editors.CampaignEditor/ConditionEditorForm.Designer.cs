namespace Leviathan.Editors.CampaignEditor
{
    partial class ConditionEditorForm
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
            this.VariablesComboBox = new System.Windows.Forms.ComboBox();
            this.OperatorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // VariablesComboBox
            // 
            this.VariablesComboBox.FormattingEnabled = true;
            this.VariablesComboBox.Location = new System.Drawing.Point(63, 12);
            this.VariablesComboBox.Name = "VariablesComboBox";
            this.VariablesComboBox.Size = new System.Drawing.Size(107, 21);
            this.VariablesComboBox.TabIndex = 0;
            this.VariablesComboBox.SelectedIndexChanged += new System.EventHandler(this.VariablesComboBox_SelectedIndexChanged);
            // 
            // OperatorComboBox
            // 
            this.OperatorComboBox.FormattingEnabled = true;
            this.OperatorComboBox.Location = new System.Drawing.Point(196, 12);
            this.OperatorComboBox.Name = "OperatorComboBox";
            this.OperatorComboBox.Size = new System.Drawing.Size(72, 21);
            this.OperatorComboBox.TabIndex = 1;
            this.OperatorComboBox.SelectedIndexChanged += new System.EventHandler(this.OperatorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Variable";
            // 
            // ManageButton
            // 
            this.ManageButton.Location = new System.Drawing.Point(63, 39);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(75, 23);
            this.ManageButton.TabIndex = 3;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "is";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "to";
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(296, 13);
            this.NumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.NumericUpDown.TabIndex = 6;
            this.NumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(277, 39);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ConditionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 72);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorComboBox);
            this.Controls.Add(this.VariablesComboBox);
            this.MaximumSize = new System.Drawing.Size(380, 110);
            this.MinimumSize = new System.Drawing.Size(380, 110);
            this.Name = "ConditionEditorForm";
            this.Text = "Edit Condition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionEditorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VariablesComboBox;
        private System.Windows.Forms.ComboBox OperatorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Button OkButton;
    }
}