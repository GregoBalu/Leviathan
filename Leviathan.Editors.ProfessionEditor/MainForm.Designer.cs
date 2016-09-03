namespace Leviathan.Editors.ProfessionEditor
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
            this.components = new System.ComponentModel.Container();
            this.ProfessionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProfessionButton = new System.Windows.Forms.Button();
            this.RemoveProfessionButton = new System.Windows.Forms.Button();
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveSkillButton = new System.Windows.Forms.Button();
            this.AddSkillButton = new System.Windows.Forms.Button();
            this.SkillListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LSpeedSetter = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.LDefenseMaxSetter = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.LDefenseMinSetter = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.LAttackMaxSetter = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.LAttackMinSetter = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.LManaSetter = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.LHealthSetter = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SpeedSetter = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.DefenseMaxSetter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.DefenseMinSetter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AttackMaxSetter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.AttackMinSetter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ManaSetter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.HealthSetter = new System.Windows.Forms.NumericUpDown();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DownSkillButton = new System.Windows.Forms.Button();
            this.UpSkillButton = new System.Windows.Forms.Button();
            this.PropertiesGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSpeedSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LDefenseMaxSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LDefenseMinSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAttackMaxSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAttackMinSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LManaSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LHealthSetter)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMaxSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMinSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMaxSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMinSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfessionListBox
            // 
            this.ProfessionListBox.FormattingEnabled = true;
            this.ProfessionListBox.Location = new System.Drawing.Point(12, 25);
            this.ProfessionListBox.Name = "ProfessionListBox";
            this.ProfessionListBox.Size = new System.Drawing.Size(120, 212);
            this.ProfessionListBox.TabIndex = 0;
            this.ProfessionListBox.SelectedIndexChanged += new System.EventHandler(this.ProfessionListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professions:";
            // 
            // AddProfessionButton
            // 
            this.AddProfessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProfessionButton.Location = new System.Drawing.Point(102, 243);
            this.AddProfessionButton.Name = "AddProfessionButton";
            this.AddProfessionButton.Size = new System.Drawing.Size(30, 30);
            this.AddProfessionButton.TabIndex = 2;
            this.AddProfessionButton.Text = "+";
            this.AddProfessionButton.UseVisualStyleBackColor = true;
            this.AddProfessionButton.Click += new System.EventHandler(this.AddProfessionButton_Click);
            // 
            // RemoveProfessionButton
            // 
            this.RemoveProfessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveProfessionButton.Location = new System.Drawing.Point(12, 243);
            this.RemoveProfessionButton.Name = "RemoveProfessionButton";
            this.RemoveProfessionButton.Size = new System.Drawing.Size(30, 30);
            this.RemoveProfessionButton.TabIndex = 3;
            this.RemoveProfessionButton.Text = "-";
            this.RemoveProfessionButton.UseVisualStyleBackColor = true;
            this.RemoveProfessionButton.Click += new System.EventHandler(this.RemoveProfessionButton_Click);
            // 
            // PropertiesGroupBox
            // 
            this.PropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertiesGroupBox.Controls.Add(this.groupBox3);
            this.PropertiesGroupBox.Controls.Add(this.groupBox2);
            this.PropertiesGroupBox.Controls.Add(this.groupBox1);
            this.PropertiesGroupBox.Location = new System.Drawing.Point(138, 12);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.Size = new System.Drawing.Size(430, 262);
            this.PropertiesGroupBox.TabIndex = 4;
            this.PropertiesGroupBox.TabStop = false;
            this.PropertiesGroupBox.Text = "Properties";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UpSkillButton);
            this.groupBox3.Controls.Add(this.DownSkillButton);
            this.groupBox3.Controls.Add(this.RemoveSkillButton);
            this.groupBox3.Controls.Add(this.AddSkillButton);
            this.groupBox3.Controls.Add(this.SkillListBox);
            this.groupBox3.Location = new System.Drawing.Point(276, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 237);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Starting Zones";
            // 
            // RemoveSkillButton
            // 
            this.RemoveSkillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSkillButton.Location = new System.Drawing.Point(6, 198);
            this.RemoveSkillButton.Name = "RemoveSkillButton";
            this.RemoveSkillButton.Size = new System.Drawing.Size(30, 30);
            this.RemoveSkillButton.TabIndex = 4;
            this.RemoveSkillButton.Text = "-";
            this.RemoveSkillButton.UseVisualStyleBackColor = true;
            this.RemoveSkillButton.Click += new System.EventHandler(this.RemoveSkillButton_Click);
            // 
            // AddSkillButton
            // 
            this.AddSkillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton.Location = new System.Drawing.Point(42, 198);
            this.AddSkillButton.Name = "AddSkillButton";
            this.AddSkillButton.Size = new System.Drawing.Size(30, 30);
            this.AddSkillButton.TabIndex = 3;
            this.AddSkillButton.Text = "+";
            this.AddSkillButton.UseVisualStyleBackColor = true;
            this.AddSkillButton.Click += new System.EventHandler(this.AddSkillButton_Click);
            // 
            // SkillListBox
            // 
            this.SkillListBox.FormattingEnabled = true;
            this.SkillListBox.Location = new System.Drawing.Point(6, 19);
            this.SkillListBox.Name = "SkillListBox";
            this.SkillListBox.Size = new System.Drawing.Size(136, 173);
            this.SkillListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.LSpeedSetter);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.LDefenseMaxSetter);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.LDefenseMinSetter);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.LAttackMaxSetter);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.LAttackMinSetter);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.LManaSetter);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.LHealthSetter);
            this.groupBox2.Location = new System.Drawing.Point(141, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 184);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Level up stats:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Speed:";
            // 
            // LSpeedSetter
            // 
            this.LSpeedSetter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LSpeedSetter.Location = new System.Drawing.Point(53, 158);
            this.LSpeedSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LSpeedSetter.Name = "LSpeedSetter";
            this.LSpeedSetter.Size = new System.Drawing.Size(70, 20);
            this.LSpeedSetter.TabIndex = 12;
            this.LSpeedSetter.ThousandsSeparator = true;
            this.LSpeedSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "-";
            // 
            // LDefenseMaxSetter
            // 
            this.LDefenseMaxSetter.Location = new System.Drawing.Point(78, 132);
            this.LDefenseMaxSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LDefenseMaxSetter.Name = "LDefenseMaxSetter";
            this.LDefenseMaxSetter.Size = new System.Drawing.Size(45, 20);
            this.LDefenseMaxSetter.TabIndex = 10;
            this.LDefenseMaxSetter.ThousandsSeparator = true;
            this.LDefenseMaxSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Defense:";
            // 
            // LDefenseMinSetter
            // 
            this.LDefenseMinSetter.Location = new System.Drawing.Point(11, 132);
            this.LDefenseMinSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LDefenseMinSetter.Name = "LDefenseMinSetter";
            this.LDefenseMinSetter.Size = new System.Drawing.Size(45, 20);
            this.LDefenseMinSetter.TabIndex = 8;
            this.LDefenseMinSetter.ThousandsSeparator = true;
            this.LDefenseMinSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "-";
            // 
            // LAttackMaxSetter
            // 
            this.LAttackMaxSetter.Location = new System.Drawing.Point(78, 89);
            this.LAttackMaxSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LAttackMaxSetter.Name = "LAttackMaxSetter";
            this.LAttackMaxSetter.Size = new System.Drawing.Size(45, 20);
            this.LAttackMaxSetter.TabIndex = 6;
            this.LAttackMaxSetter.ThousandsSeparator = true;
            this.LAttackMaxSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Attack:";
            // 
            // LAttackMinSetter
            // 
            this.LAttackMinSetter.Location = new System.Drawing.Point(11, 89);
            this.LAttackMinSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LAttackMinSetter.Name = "LAttackMinSetter";
            this.LAttackMinSetter.Size = new System.Drawing.Size(45, 20);
            this.LAttackMinSetter.TabIndex = 4;
            this.LAttackMinSetter.ThousandsSeparator = true;
            this.LAttackMinSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Mana:";
            // 
            // LManaSetter
            // 
            this.LManaSetter.Location = new System.Drawing.Point(53, 45);
            this.LManaSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LManaSetter.Name = "LManaSetter";
            this.LManaSetter.Size = new System.Drawing.Size(70, 20);
            this.LManaSetter.TabIndex = 2;
            this.LManaSetter.ThousandsSeparator = true;
            this.LManaSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Health:";
            // 
            // LHealthSetter
            // 
            this.LHealthSetter.Location = new System.Drawing.Point(53, 19);
            this.LHealthSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LHealthSetter.Name = "LHealthSetter";
            this.LHealthSetter.Size = new System.Drawing.Size(70, 20);
            this.LHealthSetter.TabIndex = 0;
            this.LHealthSetter.ThousandsSeparator = true;
            this.LHealthSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SpeedSetter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DefenseMaxSetter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DefenseMinSetter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AttackMaxSetter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AttackMinSetter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ManaSetter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HealthSetter);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start stats:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Speed:";
            // 
            // SpeedSetter
            // 
            this.SpeedSetter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedSetter.Location = new System.Drawing.Point(53, 158);
            this.SpeedSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SpeedSetter.Name = "SpeedSetter";
            this.SpeedSetter.Size = new System.Drawing.Size(70, 20);
            this.SpeedSetter.TabIndex = 12;
            this.SpeedSetter.ThousandsSeparator = true;
            this.SpeedSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // DefenseMaxSetter
            // 
            this.DefenseMaxSetter.Location = new System.Drawing.Point(78, 132);
            this.DefenseMaxSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DefenseMaxSetter.Name = "DefenseMaxSetter";
            this.DefenseMaxSetter.Size = new System.Drawing.Size(45, 20);
            this.DefenseMaxSetter.TabIndex = 10;
            this.DefenseMaxSetter.ThousandsSeparator = true;
            this.DefenseMaxSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DefenseMaxSetter.Validating += new System.ComponentModel.CancelEventHandler(this.DefenseMaxSetter_Validating);
            this.DefenseMaxSetter.Validated += new System.EventHandler(this.RangeSetter_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Defense:";
            // 
            // DefenseMinSetter
            // 
            this.DefenseMinSetter.Location = new System.Drawing.Point(11, 132);
            this.DefenseMinSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.DefenseMinSetter.Name = "DefenseMinSetter";
            this.DefenseMinSetter.Size = new System.Drawing.Size(45, 20);
            this.DefenseMinSetter.TabIndex = 8;
            this.DefenseMinSetter.ThousandsSeparator = true;
            this.DefenseMinSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DefenseMinSetter.Validating += new System.ComponentModel.CancelEventHandler(this.DefenseMinSetter_Validating);
            this.DefenseMinSetter.Validated += new System.EventHandler(this.RangeSetter_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // AttackMaxSetter
            // 
            this.AttackMaxSetter.Location = new System.Drawing.Point(78, 89);
            this.AttackMaxSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AttackMaxSetter.Name = "AttackMaxSetter";
            this.AttackMaxSetter.Size = new System.Drawing.Size(45, 20);
            this.AttackMaxSetter.TabIndex = 6;
            this.AttackMaxSetter.ThousandsSeparator = true;
            this.AttackMaxSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AttackMaxSetter.Validating += new System.ComponentModel.CancelEventHandler(this.AttackMaxSetter_Validating);
            this.AttackMaxSetter.Validated += new System.EventHandler(this.RangeSetter_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Attack:";
            // 
            // AttackMinSetter
            // 
            this.AttackMinSetter.Location = new System.Drawing.Point(11, 89);
            this.AttackMinSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AttackMinSetter.Name = "AttackMinSetter";
            this.AttackMinSetter.Size = new System.Drawing.Size(45, 20);
            this.AttackMinSetter.TabIndex = 4;
            this.AttackMinSetter.ThousandsSeparator = true;
            this.AttackMinSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AttackMinSetter.Validating += new System.ComponentModel.CancelEventHandler(this.AttackMinSetter_Validating);
            this.AttackMinSetter.Validated += new System.EventHandler(this.RangeSetter_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mana:";
            // 
            // ManaSetter
            // 
            this.ManaSetter.Location = new System.Drawing.Point(53, 45);
            this.ManaSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ManaSetter.Name = "ManaSetter";
            this.ManaSetter.Size = new System.Drawing.Size(70, 20);
            this.ManaSetter.TabIndex = 2;
            this.ManaSetter.ThousandsSeparator = true;
            this.ManaSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health:";
            // 
            // HealthSetter
            // 
            this.HealthSetter.Location = new System.Drawing.Point(53, 19);
            this.HealthSetter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HealthSetter.Name = "HealthSetter";
            this.HealthSetter.Size = new System.Drawing.Size(70, 20);
            this.HealthSetter.TabIndex = 0;
            this.HealthSetter.ThousandsSeparator = true;
            this.HealthSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HealthSetter.ValueChanged += new System.EventHandler(this.Stats_ValueChanged);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // DownSkillButton
            // 
            this.DownSkillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownSkillButton.Location = new System.Drawing.Point(76, 198);
            this.DownSkillButton.Name = "DownSkillButton";
            this.DownSkillButton.Size = new System.Drawing.Size(30, 30);
            this.DownSkillButton.TabIndex = 5;
            this.DownSkillButton.Text = "\\/";
            this.DownSkillButton.UseVisualStyleBackColor = true;
            this.DownSkillButton.Click += new System.EventHandler(this.DownSkillButton_Click);
            // 
            // UpSkillButton
            // 
            this.UpSkillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpSkillButton.Location = new System.Drawing.Point(112, 198);
            this.UpSkillButton.Name = "UpSkillButton";
            this.UpSkillButton.Size = new System.Drawing.Size(30, 30);
            this.UpSkillButton.TabIndex = 6;
            this.UpSkillButton.Text = "/\\";
            this.UpSkillButton.UseVisualStyleBackColor = true;
            this.UpSkillButton.Click += new System.EventHandler(this.UpSkillButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 286);
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.RemoveProfessionButton);
            this.Controls.Add(this.AddProfessionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfessionListBox);
            this.MinimumSize = new System.Drawing.Size(596, 325);
            this.Name = "MainForm";
            this.Text = "Profession Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.PropertiesGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSpeedSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LDefenseMaxSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LDefenseMinSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAttackMaxSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAttackMinSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LManaSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LHealthSetter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMaxSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMinSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMaxSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMinSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProfessionListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProfessionButton;
        private System.Windows.Forms.Button RemoveProfessionButton;
        private System.Windows.Forms.GroupBox PropertiesGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DefenseMaxSetter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DefenseMinSetter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AttackMaxSetter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AttackMinSetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ManaSetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HealthSetter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown SpeedSetter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown LSpeedSetter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown LDefenseMaxSetter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown LDefenseMinSetter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown LAttackMaxSetter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown LAttackMinSetter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown LManaSetter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown LHealthSetter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RemoveSkillButton;
        private System.Windows.Forms.Button AddSkillButton;
        private System.Windows.Forms.ListBox SkillListBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Button UpSkillButton;
        private System.Windows.Forms.Button DownSkillButton;
    }
}

