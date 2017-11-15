using CleanSys.Properties;
using System.Windows.Forms;

namespace CleanSys
{
    partial class ManualCleanFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualCleanFrm));
            this.AutoClean = new CCWin.SkinControl.SkinButton();
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.HomeBtn = new CCWin.SkinControl.SkinButton();
            this.rightBtn = new CCWin.SkinControl.SkinButton();
            this.stopBtn = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.upArrow = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.eightAngle1 = new MyControl.EightAngle();
            this.forwardBtn = new CCWin.SkinControl.SkinButton();
            this.backfowrdBtn = new CCWin.SkinControl.SkinButton();
            this.stepOneBtn = new CCWin.SkinControl.SkinButton();
            this.stepTwoBtn = new CCWin.SkinControl.SkinButton();
            this.stepThreeBtn = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upArrow)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoClean
            // 
            this.AutoClean.BackColor = System.Drawing.Color.Transparent;
            this.AutoClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AutoClean.BackgroundImage")));
            this.AutoClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoClean.BaseColor = System.Drawing.Color.Transparent;
            this.AutoClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AutoClean.DownBack = null;
            this.AutoClean.DownBaseColor = System.Drawing.Color.Transparent;
            this.AutoClean.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoClean.ForeColor = System.Drawing.Color.Transparent;
            this.AutoClean.Image = ((System.Drawing.Image)(resources.GetObject("AutoClean.Image")));
            this.AutoClean.IsDrawBorder = false;
            this.AutoClean.IsDrawGlass = false;
            this.AutoClean.Location = new System.Drawing.Point(152, 242);
            this.AutoClean.MouseBack = null;
            this.AutoClean.MouseBaseColor = System.Drawing.Color.Transparent;
            this.AutoClean.Name = "AutoClean";
            this.AutoClean.NormlBack = null;
            this.AutoClean.Size = new System.Drawing.Size(104, 104);
            this.AutoClean.TabIndex = 2;
            this.AutoClean.Text = "手 动\r\n清 理";
            this.AutoClean.UseVisualStyleBackColor = false;
            // 
            // DataLabel
            // 
            this.DataLabel.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataLabel.BorderColor = System.Drawing.Color.White;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataLabel.ForeColor = System.Drawing.Color.Black;
            this.DataLabel.Location = new System.Drawing.Point(616, 13);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(83, 19);
            this.DataLabel.TabIndex = 4;
            this.DataLabel.Text = "skinLabel1";
            // 
            // RTC
            // 
            this.RTC.Enabled = true;
            this.RTC.Interval = 1000;
            this.RTC.Tick += new System.EventHandler(this.RTC_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.BorderColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(1225, 13);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(83, 19);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "skinLabel1";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.HomeBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HomeBtn.DownBack = null;
            this.HomeBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.HomeBtn.IsDrawBorder = false;
            this.HomeBtn.IsDrawGlass = false;
            this.HomeBtn.Location = new System.Drawing.Point(72, 625);
            this.HomeBtn.MouseBack = null;
            this.HomeBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.NormlBack = null;
            this.HomeBtn.Size = new System.Drawing.Size(60, 60);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.BackColor = System.Drawing.Color.Transparent;
            this.rightBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightBtn.BackgroundImage")));
            this.rightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightBtn.BaseColor = System.Drawing.Color.Transparent;
            this.rightBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rightBtn.DownBack = null;
            this.rightBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.rightBtn.IsDrawBorder = false;
            this.rightBtn.IsDrawGlass = false;
            this.rightBtn.Location = new System.Drawing.Point(1240, 625);
            this.rightBtn.MouseBack = null;
            this.rightBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.NormlBack = null;
            this.rightBtn.Size = new System.Drawing.Size(60, 60);
            this.rightBtn.TabIndex = 8;
            this.rightBtn.UseVisualStyleBackColor = false;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopBtn.BackgroundImage")));
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopBtn.BaseColor = System.Drawing.Color.Transparent;
            this.stopBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.stopBtn.DownBack = null;
            this.stopBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.stopBtn.FadeGlow = false;
            this.stopBtn.IsDrawBorder = false;
            this.stopBtn.IsDrawGlass = false;
            this.stopBtn.IsEnabledDraw = false;
            this.stopBtn.Location = new System.Drawing.Point(706, 533);
            this.stopBtn.MouseBack = null;
            this.stopBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.NormlBack = null;
            this.stopBtn.Size = new System.Drawing.Size(100, 100);
            this.stopBtn.TabIndex = 9;
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.BackgroundImage")));
            this.skinPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPictureBox1.Location = new System.Drawing.Point(42, 71);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(171, 172);
            this.skinPictureBox1.TabIndex = 103;
            this.skinPictureBox1.TabStop = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(1292, 331);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(15, 17);
            this.skinLabel1.TabIndex = 108;
            this.skinLabel1.Text = "2";
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(1292, 281);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(15, 17);
            this.skinLabel2.TabIndex = 108;
            this.skinLabel2.Text = "4";
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(1291, 231);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(15, 17);
            this.skinLabel3.TabIndex = 108;
            this.skinLabel3.Text = "6";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(1291, 181);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(15, 17);
            this.skinLabel4.TabIndex = 108;
            this.skinLabel4.Text = "8";
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(1288, 131);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(22, 17);
            this.skinLabel5.TabIndex = 108;
            this.skinLabel5.Text = "10";
            // 
            // skinLabel6
            // 
            this.skinLabel6.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(1288, 81);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(22, 17);
            this.skinLabel6.TabIndex = 108;
            this.skinLabel6.Text = "12";
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(1292, 374);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(15, 17);
            this.skinLabel7.TabIndex = 108;
            this.skinLabel7.Text = "0";
            // 
            // upArrow
            // 
            this.upArrow.BackColor = System.Drawing.Color.Transparent;
            this.upArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upArrow.BackgroundImage")));
            this.upArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upArrow.Location = new System.Drawing.Point(-2, 301);
            this.upArrow.Name = "upArrow";
            this.upArrow.Size = new System.Drawing.Size(34, 38);
            this.upArrow.TabIndex = 109;
            this.upArrow.TabStop = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel1.BackgroundImage")));
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinPanel1.Controls.Add(this.upArrow);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(1254, 56);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(30, 335);
            this.skinPanel1.TabIndex = 110;
            // 
            // eightAngle1
            // 
            this.eightAngle1.BackColor = System.Drawing.Color.Transparent;
            this.eightAngle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eightAngle1.BackgroundImage")));
            this.eightAngle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eightAngle1.Location = new System.Drawing.Point(648, 56);
            this.eightAngle1.Name = "eightAngle1";
            this.eightAngle1.Size = new System.Drawing.Size(214, 214);
            this.eightAngle1.TabIndex = 106;
            // 
            // forwardBtn
            // 
            this.forwardBtn.BackColor = System.Drawing.Color.Transparent;
            this.forwardBtn.BackgroundImage = global::CleanSys.Properties.Resources.forwardBtn;
            this.forwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardBtn.BaseColor = System.Drawing.Color.Transparent;
            this.forwardBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.forwardBtn.DownBack = null;
            this.forwardBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.forwardBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.forwardBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forwardBtn.ForeColor = System.Drawing.Color.Transparent;
            this.forwardBtn.IsDrawBorder = false;
            this.forwardBtn.IsDrawGlass = false;
            this.forwardBtn.Location = new System.Drawing.Point(548, 533);
            this.forwardBtn.MouseBack = null;
            this.forwardBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.NormlBack = null;
            this.forwardBtn.Size = new System.Drawing.Size(96, 96);
            this.forwardBtn.TabIndex = 2;
            this.forwardBtn.UseVisualStyleBackColor = false;
            this.forwardBtn.Click += new System.EventHandler(this.forward_Click);
            // 
            // backfowrdBtn
            // 
            this.backfowrdBtn.BackColor = System.Drawing.Color.Transparent;
            this.backfowrdBtn.BackgroundImage = global::CleanSys.Properties.Resources.backwardBtn;
            this.backfowrdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backfowrdBtn.BaseColor = System.Drawing.Color.Transparent;
            this.backfowrdBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.backfowrdBtn.DownBack = null;
            this.backfowrdBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.backfowrdBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.backfowrdBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backfowrdBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backfowrdBtn.IsDrawBorder = false;
            this.backfowrdBtn.IsDrawGlass = false;
            this.backfowrdBtn.Location = new System.Drawing.Point(864, 534);
            this.backfowrdBtn.MouseBack = null;
            this.backfowrdBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.backfowrdBtn.Name = "backfowrdBtn";
            this.backfowrdBtn.NormlBack = null;
            this.backfowrdBtn.Size = new System.Drawing.Size(96, 96);
            this.backfowrdBtn.TabIndex = 2;
            this.backfowrdBtn.UseVisualStyleBackColor = false;
            this.backfowrdBtn.Click += new System.EventHandler(this.backward_Click);
            // 
            // stepOneBtn
            // 
            this.stepOneBtn.BackColor = System.Drawing.Color.Transparent;
            this.stepOneBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepOne;
            this.stepOneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stepOneBtn.BaseColor = System.Drawing.Color.Transparent;
            this.stepOneBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.stepOneBtn.DownBack = null;
            this.stepOneBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.stepOneBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.stepOneBtn.IsDrawBorder = false;
            this.stepOneBtn.IsDrawGlass = false;
            this.stepOneBtn.Location = new System.Drawing.Point(462, 357);
            this.stepOneBtn.MouseBack = null;
            this.stepOneBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.stepOneBtn.Name = "stepOneBtn";
            this.stepOneBtn.NormlBack = null;
            this.stepOneBtn.Size = new System.Drawing.Size(96, 96);
            this.stepOneBtn.TabIndex = 2;
            this.stepOneBtn.UseVisualStyleBackColor = false;
            this.stepOneBtn.Click += new System.EventHandler(this.StepOne_Click);
            // 
            // stepTwoBtn
            // 
            this.stepTwoBtn.BackColor = System.Drawing.Color.Transparent;
            this.stepTwoBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepTwo;
            this.stepTwoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stepTwoBtn.BaseColor = System.Drawing.Color.Transparent;
            this.stepTwoBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.stepTwoBtn.DownBack = null;
            this.stepTwoBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.stepTwoBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.stepTwoBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepTwoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.stepTwoBtn.IsDrawBorder = false;
            this.stepTwoBtn.IsDrawGlass = false;
            this.stepTwoBtn.Location = new System.Drawing.Point(709, 357);
            this.stepTwoBtn.MouseBack = null;
            this.stepTwoBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.stepTwoBtn.Name = "stepTwoBtn";
            this.stepTwoBtn.NormlBack = null;
            this.stepTwoBtn.Size = new System.Drawing.Size(96, 96);
            this.stepTwoBtn.TabIndex = 2;
            this.stepTwoBtn.UseVisualStyleBackColor = false;
            this.stepTwoBtn.Click += new System.EventHandler(this.StepTwo_Click);
            // 
            // stepThreeBtn
            // 
            this.stepThreeBtn.BackColor = System.Drawing.Color.Transparent;
            this.stepThreeBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepThree;
            this.stepThreeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stepThreeBtn.BaseColor = System.Drawing.Color.Transparent;
            this.stepThreeBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.stepThreeBtn.DownBack = null;
            this.stepThreeBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.stepThreeBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.stepThreeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepThreeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.stepThreeBtn.IsDrawBorder = false;
            this.stepThreeBtn.IsDrawGlass = false;
            this.stepThreeBtn.Location = new System.Drawing.Point(966, 357);
            this.stepThreeBtn.MouseBack = null;
            this.stepThreeBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.stepThreeBtn.Name = "stepThreeBtn";
            this.stepThreeBtn.NormlBack = null;
            this.stepThreeBtn.Size = new System.Drawing.Size(96, 96);
            this.stepThreeBtn.TabIndex = 2;
            this.stepThreeBtn.UseVisualStyleBackColor = false;
            this.stepThreeBtn.Click += new System.EventHandler(this.StepThree_Click);
            // 
            // ManualCleanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 727);
            this.ControlBox = false;
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.eightAngle1);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.backfowrdBtn);
            this.Controls.Add(this.stepThreeBtn);
            this.Controls.Add(this.stepTwoBtn);
            this.Controls.Add(this.stepOneBtn);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.AutoClean);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TimeLabel);
            this.Name = "ManualCleanFrm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.ManualCleanFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upArrow)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton AutoClean;
        protected CCWin.SkinControl.SkinLabel DataLabel;
        protected System.Windows.Forms.Timer RTC;
        protected CCWin.SkinControl.SkinLabel TimeLabel;
        private CCWin.SkinControl.SkinButton HomeBtn;
        private CCWin.SkinControl.SkinButton rightBtn;
        private CCWin.SkinControl.SkinButton stopBtn;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private MyControl.EightAngle eightAngle1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinPictureBox upArrow;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton forwardBtn;
        private CCWin.SkinControl.SkinButton backfowrdBtn;
        private CCWin.SkinControl.SkinButton stepOneBtn;
        private CCWin.SkinControl.SkinButton stepTwoBtn;
        private CCWin.SkinControl.SkinButton stepThreeBtn;
    }
}