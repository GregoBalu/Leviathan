namespace Leviathan.Editors.CharacterEditor
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RaceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.StatGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HealthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ManaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AttackMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DefenseMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.AttackMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DefenseMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.StatGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(177, 252);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(12, 252);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RaceComboBox
            // 
            this.RaceComboBox.FormattingEnabled = true;
            this.RaceComboBox.Location = new System.Drawing.Point(67, 12);
            this.RaceComboBox.Name = "RaceComboBox";
            this.RaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.RaceComboBox.TabIndex = 2;
            this.RaceComboBox.SelectedIndexChanged += new System.EventHandler(this.RaceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Race:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class:";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(67, 39);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 5;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // StatGroupBox
            // 
            this.StatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatGroupBox.Controls.Add(this.LevelNumericUpDown);
            this.StatGroupBox.Controls.Add(this.label10);
            this.StatGroupBox.Controls.Add(this.label9);
            this.StatGroupBox.Controls.Add(this.label8);
            this.StatGroupBox.Controls.Add(this.DefenseMaxNumericUpDown);
            this.StatGroupBox.Controls.Add(this.AttackMaxNumericUpDown);
            this.StatGroupBox.Controls.Add(this.SpeedNumericUpDown);
            this.StatGroupBox.Controls.Add(this.label7);
            this.StatGroupBox.Controls.Add(this.DefenseMinNumericUpDown);
            this.StatGroupBox.Controls.Add(this.label6);
            this.StatGroupBox.Controls.Add(this.AttackMinNumericUpDown);
            this.StatGroupBox.Controls.Add(this.label5);
            this.StatGroupBox.Controls.Add(this.ManaNumericUpDown);
            this.StatGroupBox.Controls.Add(this.label4);
            this.StatGroupBox.Controls.Add(this.HealthNumericUpDown);
            this.StatGroupBox.Controls.Add(this.label3);
            this.StatGroupBox.Location = new System.Drawing.Point(12, 66);
            this.StatGroupBox.Name = "StatGroupBox";
            this.StatGroupBox.Size = new System.Drawing.Size(242, 180);
            this.StatGroupBox.TabIndex = 6;
            this.StatGroupBox.TabStop = false;
            this.StatGroupBox.Text = "Stats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Health:";
            // 
            // HealthNumericUpDown
            // 
            this.HealthNumericUpDown.Location = new System.Drawing.Point(74, 19);
            this.HealthNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HealthNumericUpDown.Name = "HealthNumericUpDown";
            this.HealthNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.HealthNumericUpDown.TabIndex = 1;
            this.HealthNumericUpDown.ValueChanged += new System.EventHandler(this.HealthNumericUpDown_ValueChanged);
            // 
            // ManaNumericUpDown
            // 
            this.ManaNumericUpDown.Location = new System.Drawing.Point(74, 45);
            this.ManaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ManaNumericUpDown.Name = "ManaNumericUpDown";
            this.ManaNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.ManaNumericUpDown.TabIndex = 3;
            this.ManaNumericUpDown.ValueChanged += new System.EventHandler(this.ManaNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mana:";
            // 
            // AttackMinNumericUpDown
            // 
            this.AttackMinNumericUpDown.Location = new System.Drawing.Point(74, 71);
            this.AttackMinNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AttackMinNumericUpDown.Name = "AttackMinNumericUpDown";
            this.AttackMinNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.AttackMinNumericUpDown.TabIndex = 5;
            this.AttackMinNumericUpDown.ValueChanged += new System.EventHandler(this.AttackMinNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Attack:";
            // 
            // DefenseMinNumericUpDown
            // 
            this.DefenseMinNumericUpDown.Location = new System.Drawing.Point(74, 97);
            this.DefenseMinNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DefenseMinNumericUpDown.Name = "DefenseMinNumericUpDown";
            this.DefenseMinNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.DefenseMinNumericUpDown.TabIndex = 7;
            this.DefenseMinNumericUpDown.ValueChanged += new System.EventHandler(this.DefenseMinNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Defense:";
            // 
            // SpeedNumericUpDown
            // 
            this.SpeedNumericUpDown.Location = new System.Drawing.Point(74, 123);
            this.SpeedNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SpeedNumericUpDown.Name = "SpeedNumericUpDown";
            this.SpeedNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.SpeedNumericUpDown.TabIndex = 9;
            this.SpeedNumericUpDown.ValueChanged += new System.EventHandler(this.SpeedNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Speed:";
            // 
            // AttackMaxNumericUpDown
            // 
            this.AttackMaxNumericUpDown.Location = new System.Drawing.Point(166, 71);
            this.AttackMaxNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AttackMaxNumericUpDown.Name = "AttackMaxNumericUpDown";
            this.AttackMaxNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.AttackMaxNumericUpDown.TabIndex = 10;
            this.AttackMaxNumericUpDown.ValueChanged += new System.EventHandler(this.AttackMaxNumericUpDown_ValueChanged);
            // 
            // DefenseMaxNumericUpDown
            // 
            this.DefenseMaxNumericUpDown.Location = new System.Drawing.Point(166, 97);
            this.DefenseMaxNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DefenseMaxNumericUpDown.Name = "DefenseMaxNumericUpDown";
            this.DefenseMaxNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.DefenseMaxNumericUpDown.TabIndex = 11;
            this.DefenseMaxNumericUpDown.ValueChanged += new System.EventHandler(this.DefenseMaxNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = " - ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = " - ";
            // 
            // LevelNumericUpDown
            // 
            this.LevelNumericUpDown.Location = new System.Drawing.Point(74, 149);
            this.LevelNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LevelNumericUpDown.Name = "LevelNumericUpDown";
            this.LevelNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.LevelNumericUpDown.TabIndex = 15;
            this.LevelNumericUpDown.ValueChanged += new System.EventHandler(this.LevelNumericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Level:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 287);
            this.Controls.Add(this.StatGroupBox);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RaceComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.MaximumSize = new System.Drawing.Size(280, 325);
            this.MinimumSize = new System.Drawing.Size(280, 325);
            this.Name = "MainForm";
            this.Text = "Character Editor";
            this.StatGroupBox.ResumeLayout(false);
            this.StatGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox RaceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.GroupBox StatGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SpeedNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DefenseMinNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AttackMinNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ManaNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown HealthNumericUpDown;
        private System.Windows.Forms.NumericUpDown AttackMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown DefenseMaxNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown LevelNumericUpDown;
        private System.Windows.Forms.Label label10;
    }
}

