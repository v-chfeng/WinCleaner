namespace CleanSys
{
    partial class CHeckFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHeckFrm));
            this.TermalCheck = new CCWin.SkinControl.SkinProgressBar();
            this.LoadCarCheck = new CCWin.SkinControl.SkinProgressBar();
            this.RailCleanCarCheck = new CCWin.SkinControl.SkinProgressBar();
            this.Check = new CCWin.SkinControl.SkinButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Home = new CCWin.SkinControl.SkinButton();
            this.BackBtn = new CCWin.SkinControl.SkinButton();
            this.Front = new CCWin.SkinControl.SkinButton();
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TermalCheck
            // 
            this.TermalCheck.Back = null;
            this.TermalCheck.BackColor = System.Drawing.Color.Transparent;
            this.TermalCheck.BarBack = null;
            this.TermalCheck.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.TermalCheck.ForeColor = System.Drawing.Color.Red;
            this.TermalCheck.Location = new System.Drawing.Point(386, 93);
            this.TermalCheck.Name = "TermalCheck";
            this.TermalCheck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.TermalCheck.Size = new System.Drawing.Size(241, 23);
            this.TermalCheck.TabIndex = 0;
            // 
            // LoadCarCheck
            // 
            this.LoadCarCheck.Back = null;
            this.LoadCarCheck.BackColor = System.Drawing.Color.Transparent;
            this.LoadCarCheck.BarBack = null;
            this.LoadCarCheck.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.LoadCarCheck.ForeColor = System.Drawing.Color.Red;
            this.LoadCarCheck.Location = new System.Drawing.Point(386, 165);
            this.LoadCarCheck.Name = "LoadCarCheck";
            this.LoadCarCheck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.LoadCarCheck.Size = new System.Drawing.Size(241, 23);
            this.LoadCarCheck.TabIndex = 0;
            // 
            // RailCleanCarCheck
            // 
            this.RailCleanCarCheck.Back = null;
            this.RailCleanCarCheck.BackColor = System.Drawing.Color.Transparent;
            this.RailCleanCarCheck.BarBack = null;
            this.RailCleanCarCheck.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.RailCleanCarCheck.ForeColor = System.Drawing.Color.Red;
            this.RailCleanCarCheck.Location = new System.Drawing.Point(386, 225);
            this.RailCleanCarCheck.Name = "RailCleanCarCheck";
            this.RailCleanCarCheck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.RailCleanCarCheck.Size = new System.Drawing.Size(241, 23);
            this.RailCleanCarCheck.TabIndex = 0;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BaseColor = System.Drawing.Color.Black;
            this.Check.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Check.DownBack = null;
            this.Check.ForeColor = System.Drawing.Color.White;
            this.Check.Location = new System.Drawing.Point(90, 79);
            this.Check.MouseBack = null;
            this.Check.Name = "Check";
            this.Check.NormlBack = null;
            this.Check.Size = new System.Drawing.Size(83, 74);
            this.Check.TabIndex = 1;
            this.Check.Text = "check\r\n自检";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Home.DownBack = null;
            this.Home.Location = new System.Drawing.Point(100, 353);
            this.Home.MouseBack = null;
            this.Home.Name = "Home";
            this.Home.NormlBack = null;
            this.Home.Size = new System.Drawing.Size(52, 44);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Back
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BackBtn.DownBack = null;
            this.BackBtn.Location = new System.Drawing.Point(465, 365);
            this.BackBtn.MouseBack = null;
            this.BackBtn.Name = "Back";
            this.BackBtn.NormlBack = null;
            this.BackBtn.Size = new System.Drawing.Size(38, 31);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.Back_Click);
            // 
            // Front
            // 
            this.Front.BackColor = System.Drawing.Color.Transparent;
            this.Front.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Front.DownBack = null;
            this.Front.Location = new System.Drawing.Point(587, 365);
            this.Front.MouseBack = null;
            this.Front.Name = "Front";
            this.Front.NormlBack = null;
            this.Front.Size = new System.Drawing.Size(40, 32);
            this.Front.TabIndex = 4;
            this.Front.Text = "Front";
            this.Front.UseVisualStyleBackColor = false;
            // 
            // DataLabel
            // 
            this.DataLabel.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
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
            this.TimeLabel.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
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
            // RTC
            // 
            this.RTC.Enabled = true;
            this.RTC.Interval = 1000;
            this.RTC.Tick += new System.EventHandler(this.RTC_Tick);
            // 
            // CHeckFrm
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
            this.Controls.Add(this.Front);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.RailCleanCarCheck);
            this.Controls.Add(this.LoadCarCheck);
            this.Controls.Add(this.TermalCheck);
            this.Name = "CHeckFrm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClearnFrm_FormClosing);
            this.Load += new System.EventHandler(this.ClearnFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinProgressBar TermalCheck;
        private CCWin.SkinControl.SkinProgressBar LoadCarCheck;
        private CCWin.SkinControl.SkinProgressBar RailCleanCarCheck;
        private CCWin.SkinControl.SkinButton Check;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton Home;
        private CCWin.SkinControl.SkinButton BackBtn;
        private CCWin.SkinControl.SkinButton Front;
        private CCWin.SkinControl.SkinLabel DataLabel;
        private CCWin.SkinControl.SkinLabel TimeLabel;
        private System.Windows.Forms.Timer RTC;
    }
}