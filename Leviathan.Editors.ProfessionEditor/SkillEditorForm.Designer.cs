namespace Leviathan.Editors.ProfessionEditor
{
    partial class SkillEditorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UseMessageTextBox = new System.Windows.Forms.TextBox();
            this.ToolTipTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LevelReqNnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CooldownNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ManaCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IsUnlockedCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ImageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelReqNnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaCostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UseMessageTextBox);
            this.groupBox1.Controls.Add(this.ToolTipTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DisplayNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String properties:";
            // 
            // UseMessageTextBox
            // 
            this.UseMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseMessageTextBox.Location = new System.Drawing.Point(103, 126);
            this.UseMessageTextBox.Multiline = true;
            this.UseMessageTextBox.Name = "UseMessageTextBox";
            this.UseMessageTextBox.Size = new System.Drawing.Size(116, 75);
            this.UseMessageTextBox.TabIndex = 5;
            this.UseMessageTextBox.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // ToolTipTextBox
            // 
            this.ToolTipTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolTipTextBox.Location = new System.Drawing.Point(103, 45);
            this.ToolTipTextBox.Multiline = true;
            this.ToolTipTextBox.Name = "ToolTipTextBox";
            this.ToolTipTextBox.Size = new System.Drawing.Size(116, 75);
            this.ToolTipTextBox.TabIndex = 4;
            this.ToolTipTextBox.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Use Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ToolTip:";
            // 
            // DisplayNameTextBox
            // 
            this.DisplayNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayNameTextBox.Location = new System.Drawing.Point(103, 19);
            this.DisplayNameTextBox.Name = "DisplayNameTextBox";
            this.DisplayNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.DisplayNameTextBox.TabIndex = 1;
            this.DisplayNameTextBox.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ImageButton);
            this.groupBox2.Controls.Add(this.ImagePictureBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.IsUnlockedCheckBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DurationNumericUpDown);
            this.groupBox2.Controls.Add(this.RangeNumericUpDown);
            this.groupBox2.Controls.Add(this.ManaCostNumericUpDown);
            this.groupBox2.Controls.Add(this.CooldownNumericUpDown);
            this.groupBox2.Controls.Add(this.LevelReqNnumericUpDown);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utility properties:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Level requirement:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cooldown (turns):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mana cost:";
            // 
            // LevelReqNnumericUpDown
            // 
            this.LevelReqNnumericUpDown.Location = new System.Drawing.Point(147, 19);
            this.LevelReqNnumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LevelReqNnumericUpDown.Name = "LevelReqNnumericUpDown";
            this.LevelReqNnumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.LevelReqNnumericUpDown.TabIndex = 3;
            this.LevelReqNnumericUpDown.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // CooldownNumericUpDown
            // 
            this.CooldownNumericUpDown.Location = new System.Drawing.Point(118, 45);
            this.CooldownNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CooldownNumericUpDown.Name = "CooldownNumericUpDown";
            this.CooldownNumericUpDown.Size = new System.Drawing.Size(101, 20);
            this.CooldownNumericUpDown.TabIndex = 4;
            this.CooldownNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // ManaCostNumericUpDown
            // 
            this.ManaCostNumericUpDown.Location = new System.Drawing.Point(118, 71);
            this.ManaCostNumericUpDown.Name = "ManaCostNumericUpDown";
            this.ManaCostNumericUpDown.Size = new System.Drawing.Size(101, 20);
            this.ManaCostNumericUpDown.TabIndex = 5;
            this.ManaCostNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // RangeNumericUpDown
            // 
            this.RangeNumericUpDown.Location = new System.Drawing.Point(147, 97);
            this.RangeNumericUpDown.Name = "RangeNumericUpDown";
            this.RangeNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.RangeNumericUpDown.TabIndex = 6;
            this.RangeNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // DurationNumericUpDown
            // 
            this.DurationNumericUpDown.Location = new System.Drawing.Point(118, 123);
            this.DurationNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DurationNumericUpDown.Name = "DurationNumericUpDown";
            this.DurationNumericUpDown.Size = new System.Drawing.Size(101, 20);
            this.DurationNumericUpDown.TabIndex = 7;
            this.DurationNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Range:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Duration (turns):";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(243, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 474);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stat changes:";
            // 
            // IsUnlockedCheckBox
            // 
            this.IsUnlockedCheckBox.AutoSize = true;
            this.IsUnlockedCheckBox.Location = new System.Drawing.Point(24, 149);
            this.IsUnlockedCheckBox.Name = "IsUnlockedCheckBox";
            this.IsUnlockedCheckBox.Size = new System.Drawing.Size(81, 17);
            this.IsUnlockedCheckBox.TabIndex = 10;
            this.IsUnlockedCheckBox.Text = "Is unlocked";
            this.IsUnlockedCheckBox.UseVisualStyleBackColor = true;
            this.IsUnlockedCheckBox.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Image:";
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(51, 169);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(80, 80);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePictureBox.TabIndex = 12;
            this.ImagePictureBox.TabStop = false;
            // 
            // ImageButton
            // 
            this.ImageButton.Location = new System.Drawing.Point(137, 169);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(82, 23);
            this.ImageButton.TabIndex = 13;
            this.ImageButton.Text = "Add";
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // SkillEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SkillEditorForm";
            this.Text = "Skill Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillEditorForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelReqNnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaCostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DisplayNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UseMessageTextBox;
        private System.Windows.Forms.TextBox ToolTipTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ManaCostNumericUpDown;
        private System.Windows.Forms.NumericUpDown CooldownNumericUpDown;
        private System.Windows.Forms.NumericUpDown LevelReqNnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DurationNumericUpDown;
        private System.Windows.Forms.NumericUpDown RangeNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox IsUnlockedCheckBox;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label label9;
    }
}