namespace CleanSys
{
    partial class RecordFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordFrm));
            this.Record = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b28 = new CCWin.SkinControl.SkinButton();
            this.b27 = new CCWin.SkinControl.SkinButton();
            this.b26 = new CCWin.SkinControl.SkinButton();
            this.b25 = new CCWin.SkinControl.SkinButton();
            this.b24 = new CCWin.SkinControl.SkinButton();
            this.b23 = new CCWin.SkinControl.SkinButton();
            this.b22 = new CCWin.SkinControl.SkinButton();
            this.b21 = new CCWin.SkinControl.SkinButton();
            this.b18 = new CCWin.SkinControl.SkinButton();
            this.b17 = new CCWin.SkinControl.SkinButton();
            this.b16 = new CCWin.SkinControl.SkinButton();
            this.b15 = new CCWin.SkinControl.SkinButton();
            this.b14 = new CCWin.SkinControl.SkinButton();
            this.b13 = new CCWin.SkinControl.SkinButton();
            this.b12 = new CCWin.SkinControl.SkinButton();
            this.b11 = new CCWin.SkinControl.SkinButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Home = new CCWin.SkinControl.SkinButton();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Record
            // 
            this.Record.BackColor = System.Drawing.Color.Transparent;
            this.Record.BaseColor = System.Drawing.Color.Black;
            this.Record.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Record.DownBack = null;
            this.Record.ForeColor = System.Drawing.Color.White;
            this.Record.Location = new System.Drawing.Point(560, 121);
            this.Record.MouseBack = null;
            this.Record.Name = "Record";
            this.Record.NormlBack = null;
            this.Record.Size = new System.Drawing.Size(204, 58);
            this.Record.TabIndex = 2;
            this.Record.Text = "记录  Record";
            this.Record.UseVisualStyleBackColor = false;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "箱编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "操作员";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "箱壁清理状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "箱壁清理时间";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.comboBox1.Location = new System.Drawing.Point(345, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "张三",
            "李四"});
            this.comboBox2.Location = new System.Drawing.Point(497, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "清理完毕",
            "尚未清理"});
            this.comboBox3.Location = new System.Drawing.Point(693, 212);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(105, 20);
            this.comboBox3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(894, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent; //System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.b28);
            this.groupBox1.Controls.Add(this.b27);
            this.groupBox1.Controls.Add(this.b26);
            this.groupBox1.Controls.Add(this.b25);
            this.groupBox1.Controls.Add(this.b24);
            this.groupBox1.Controls.Add(this.b23);
            this.groupBox1.Controls.Add(this.b22);
            this.groupBox1.Controls.Add(this.b21);
            this.groupBox1.Controls.Add(this.b18);
            this.groupBox1.Controls.Add(this.b17);
            this.groupBox1.Controls.Add(this.b16);
            this.groupBox1.Controls.Add(this.b15);
            this.groupBox1.Controls.Add(this.b14);
            this.groupBox1.Controls.Add(this.b13);
            this.groupBox1.Controls.Add(this.b12);
            this.groupBox1.Controls.Add(this.b11);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(302, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 263);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // b28
            // 
            this.b28.BackColor = System.Drawing.Color.Black;
            this.b28.BaseColor = System.Drawing.Color.Black;
            this.b28.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b28.DownBack = null;
            this.b28.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b28.Location = new System.Drawing.Point(632, 128);
            this.b28.MouseBack = null;
            this.b28.MouseBaseColor = System.Drawing.Color.Black;
            this.b28.Name = "b28";
            this.b28.NormlBack = null;
            this.b28.Size = new System.Drawing.Size(34, 15);
            this.b28.TabIndex = 7;
            this.b28.UseVisualStyleBackColor = false;
            // 
            // b27
            // 
            this.b27.BackColor = System.Drawing.Color.Black;
            this.b27.BaseColor = System.Drawing.Color.Black;
            this.b27.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b27.DownBack = null;
            this.b27.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b27.Location = new System.Drawing.Point(552, 128);
            this.b27.MouseBack = null;
            this.b27.MouseBaseColor = System.Drawing.Color.Black;
            this.b27.Name = "b27";
            this.b27.NormlBack = null;
            this.b27.Size = new System.Drawing.Size(34, 15);
            this.b27.TabIndex = 8;
            this.b27.UseVisualStyleBackColor = false;
            // 
            // b26
            // 
            this.b26.BackColor = System.Drawing.Color.Black;
            this.b26.BaseColor = System.Drawing.Color.Black;
            this.b26.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b26.DownBack = null;
            this.b26.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b26.Location = new System.Drawing.Point(486, 128);
            this.b26.MouseBack = null;
            this.b26.MouseBaseColor = System.Drawing.Color.Black;
            this.b26.Name = "b26";
            this.b26.NormlBack = null;
            this.b26.Size = new System.Drawing.Size(34, 15);
            this.b26.TabIndex = 9;
            this.b26.UseVisualStyleBackColor = false;
            // 
            // b25
            // 
            this.b25.BackColor = System.Drawing.Color.Black;
            this.b25.BaseColor = System.Drawing.Color.Black;
            this.b25.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b25.DownBack = null;
            this.b25.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b25.Location = new System.Drawing.Point(414, 128);
            this.b25.MouseBack = null;
            this.b25.MouseBaseColor = System.Drawing.Color.Black;
            this.b25.Name = "b25";
            this.b25.NormlBack = null;
            this.b25.Size = new System.Drawing.Size(34, 15);
            this.b25.TabIndex = 10;
            this.b25.UseVisualStyleBackColor = false;
            // 
            // b24
            // 
            this.b24.BackColor = System.Drawing.Color.Black;
            this.b24.BaseColor = System.Drawing.Color.Black;
            this.b24.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b24.DownBack = null;
            this.b24.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b24.Location = new System.Drawing.Point(344, 128);
            this.b24.MouseBack = null;
            this.b24.MouseBaseColor = System.Drawing.Color.Black;
            this.b24.Name = "b24";
            this.b24.NormlBack = null;
            this.b24.Size = new System.Drawing.Size(34, 15);
            this.b24.TabIndex = 11;
            this.b24.UseVisualStyleBackColor = false;
            // 
            // b23
            // 
            this.b23.BackColor = System.Drawing.Color.Black;
            this.b23.BaseColor = System.Drawing.Color.Black;
            this.b23.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b23.DownBack = null;
            this.b23.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b23.Location = new System.Drawing.Point(275, 128);
            this.b23.MouseBack = null;
            this.b23.MouseBaseColor = System.Drawing.Color.Black;
            this.b23.Name = "b23";
            this.b23.NormlBack = null;
            this.b23.Size = new System.Drawing.Size(34, 15);
            this.b23.TabIndex = 12;
            this.b23.UseVisualStyleBackColor = false;
            // 
            // b22
            // 
            this.b22.BackColor = System.Drawing.Color.Black;
            this.b22.BaseColor = System.Drawing.Color.Black;
            this.b22.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b22.DownBack = null;
            this.b22.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b22.Location = new System.Drawing.Point(201, 128);
            this.b22.MouseBack = null;
            this.b22.MouseBaseColor = System.Drawing.Color.Black;
            this.b22.Name = "b22";
            this.b22.NormlBack = null;
            this.b22.Size = new System.Drawing.Size(34, 15);
            this.b22.TabIndex = 13;
            this.b22.UseVisualStyleBackColor = false;
            // 
            // b21
            // 
            this.b21.BackColor = System.Drawing.Color.Black;
            this.b21.BaseColor = System.Drawing.Color.Black;
            this.b21.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b21.DownBack = null;
            this.b21.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b21.Location = new System.Drawing.Point(123, 128);
            this.b21.MouseBack = null;
            this.b21.MouseBaseColor = System.Drawing.Color.Black;
            this.b21.Name = "b21";
            this.b21.NormlBack = null;
            this.b21.Size = new System.Drawing.Size(34, 15);
            this.b21.TabIndex = 6;
            this.b21.UseVisualStyleBackColor = false;
            this.b21.Click += new System.EventHandler(this.b21_Click);
            // 
            // b18
            // 
            this.b18.BackColor = System.Drawing.Color.Black;
            this.b18.BaseColor = System.Drawing.Color.Black;
            this.b18.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b18.DownBack = null;
            this.b18.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b18.Location = new System.Drawing.Point(631, 82);
            this.b18.MouseBack = null;
            this.b18.MouseBaseColor = System.Drawing.Color.Black;
            this.b18.Name = "b18";
            this.b18.NormlBack = null;
            this.b18.Size = new System.Drawing.Size(34, 15);
            this.b18.TabIndex = 5;
            this.b18.UseVisualStyleBackColor = false;
            this.b18.Click += new System.EventHandler(this.b18_Click);
            // 
            // b17
            // 
            this.b17.BackColor = System.Drawing.Color.Black;
            this.b17.BaseColor = System.Drawing.Color.Black;
            this.b17.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b17.DownBack = null;
            this.b17.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b17.Location = new System.Drawing.Point(551, 82);
            this.b17.MouseBack = null;
            this.b17.MouseBaseColor = System.Drawing.Color.Black;
            this.b17.Name = "b17";
            this.b17.NormlBack = null;
            this.b17.Size = new System.Drawing.Size(34, 15);
            this.b17.TabIndex = 5;
            this.b17.UseVisualStyleBackColor = false;
            this.b17.Click += new System.EventHandler(this.b17_Click);
            // 
            // b16
            // 
            this.b16.BackColor = System.Drawing.Color.Black;
            this.b16.BaseColor = System.Drawing.Color.Black;
            this.b16.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b16.DownBack = null;
            this.b16.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b16.Location = new System.Drawing.Point(485, 82);
            this.b16.MouseBack = null;
            this.b16.MouseBaseColor = System.Drawing.Color.Black;
            this.b16.Name = "b16";
            this.b16.NormlBack = null;
            this.b16.Size = new System.Drawing.Size(34, 15);
            this.b16.TabIndex = 5;
            this.b16.UseVisualStyleBackColor = false;
            this.b16.Click += new System.EventHandler(this.b16_Click);
            // 
            // b15
            // 
            this.b15.BackColor = System.Drawing.Color.Black;
            this.b15.BaseColor = System.Drawing.Color.Black;
            this.b15.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b15.DownBack = null;
            this.b15.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b15.Location = new System.Drawing.Point(413, 82);
            this.b15.MouseBack = null;
            this.b15.MouseBaseColor = System.Drawing.Color.Black;
            this.b15.Name = "b15";
            this.b15.NormlBack = null;
            this.b15.Size = new System.Drawing.Size(34, 15);
            this.b15.TabIndex = 5;
            this.b15.UseVisualStyleBackColor = false;
            this.b15.Click += new System.EventHandler(this.b15_Click);
            // 
            // b14
            // 
            this.b14.BackColor = System.Drawing.Color.Black;
            this.b14.BaseColor = System.Drawing.Color.Black;
            this.b14.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b14.DownBack = null;
            this.b14.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b14.Location = new System.Drawing.Point(343, 82);
            this.b14.MouseBack = null;
            this.b14.MouseBaseColor = System.Drawing.Color.Black;
            this.b14.Name = "b14";
            this.b14.NormlBack = null;
            this.b14.Size = new System.Drawing.Size(34, 15);
            this.b14.TabIndex = 5;
            this.b14.UseVisualStyleBackColor = false;
            this.b14.Click += new System.EventHandler(this.b14_Click);
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.Black;
            this.b13.BaseColor = System.Drawing.Color.Black;
            this.b13.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b13.DownBack = null;
            this.b13.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b13.Location = new System.Drawing.Point(274, 82);
            this.b13.MouseBack = null;
            this.b13.MouseBaseColor = System.Drawing.Color.Black;
            this.b13.Name = "b13";
            this.b13.NormlBack = null;
            this.b13.Size = new System.Drawing.Size(34, 15);
            this.b13.TabIndex = 5;
            this.b13.UseVisualStyleBackColor = false;
            this.b13.Click += new System.EventHandler(this.b13_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.Black;
            this.b12.BaseColor = System.Drawing.Color.Black;
            this.b12.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b12.DownBack = null;
            this.b12.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b12.Location = new System.Drawing.Point(200, 82);
            this.b12.MouseBack = null;
            this.b12.MouseBaseColor = System.Drawing.Color.Black;
            this.b12.Name = "b12";
            this.b12.NormlBack = null;
            this.b12.Size = new System.Drawing.Size(34, 15);
            this.b12.TabIndex = 5;
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.Black;
            this.b11.BaseColor = System.Drawing.Color.Black;
            this.b11.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b11.DownBack = null;
            this.b11.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b11.Location = new System.Drawing.Point(122, 82);
            this.b11.MouseBack = null;
            this.b11.MouseBaseColor = System.Drawing.Color.Black;
            this.b11.Name = "b11";
            this.b11.NormlBack = null;
            this.b11.Size = new System.Drawing.Size(34, 15);
            this.b11.TabIndex = 4;
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "轨道编号";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "检测点1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "检测点2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "检测点3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "检测点4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "检测点5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "检测点6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "检测点7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "检测点8";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Home.DownBack = null;
            this.Home.Location = new System.Drawing.Point(50, 461);
            this.Home.MouseBack = null;
            this.Home.Name = "Home";
            this.Home.NormlBack = null;
            this.Home.Size = new System.Drawing.Size(52, 44);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // RTC
            // 
            this.RTC.Enabled = true;
            this.RTC.Interval = 1000;
            this.RTC.Tick += new System.EventHandler(this.RTC_Tick);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataLabel.BorderColor = System.Drawing.Color.White;
            this.DataLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataLabel.ForeColor = System.Drawing.Color.Black;
            this.DataLabel.Location = new System.Drawing.Point(616, 13);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(83, 19);
            this.DataLabel.TabIndex = 1;
            this.DataLabel.Text = "skinLabel1";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.BorderColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(1225, 13);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(83, 19);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "skinLabel1";
            // 
            // RecordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 727);
            this.ControlBox = false;
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Record);
            this.Name = "RecordFrm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.RecordFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton Record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinButton b11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinButton b18;
        private CCWin.SkinControl.SkinButton b17;
        private CCWin.SkinControl.SkinButton b16;
        private CCWin.SkinControl.SkinButton b15;
        private CCWin.SkinControl.SkinButton b14;
        private CCWin.SkinControl.SkinButton b13;
        private CCWin.SkinControl.SkinButton b12;
        private CCWin.SkinControl.SkinButton Home;
        private System.Windows.Forms.Timer RTC;
        private CCWin.SkinControl.SkinLabel DataLabel;
        private CCWin.SkinControl.SkinLabel TimeLabel;
        private CCWin.SkinControl.SkinButton b28;
        private CCWin.SkinControl.SkinButton b27;
        private CCWin.SkinControl.SkinButton b26;
        private CCWin.SkinControl.SkinButton b25;
        private CCWin.SkinControl.SkinButton b24;
        private CCWin.SkinControl.SkinButton b23;
        private CCWin.SkinControl.SkinButton b22;
        private CCWin.SkinControl.SkinButton b21;
    }
}