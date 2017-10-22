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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.CkeckBtn = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.HomeBtn = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.rightBtn = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TermalCheck
            // 
            this.TermalCheck.Back = null;
            this.TermalCheck.BackColor = System.Drawing.Color.Black;
            this.TermalCheck.BarBack = null;
            this.TermalCheck.BarGlass = false;
            this.TermalCheck.BarRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.TermalCheck.Border = System.Drawing.Color.Black;
            this.TermalCheck.Enabled = false;
            this.TermalCheck.ForeColor = System.Drawing.Color.Black;
            this.TermalCheck.Glass = false;
            this.TermalCheck.InnerBorder = System.Drawing.Color.Black;
            this.TermalCheck.Location = new System.Drawing.Point(556, 200);
            this.TermalCheck.MarqueeAnimationSpeed = 1;
            this.TermalCheck.Name = "TermalCheck";
            this.TermalCheck.Radius = 1;
            this.TermalCheck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.TermalCheck.Size = new System.Drawing.Size(323, 30);
            this.TermalCheck.TabIndex = 0;
            this.TermalCheck.TextFormat = CCWin.SkinControl.SkinProgressBar.TxtFormat.None;
            this.TermalCheck.TrackBack = System.Drawing.Color.Black;
            this.TermalCheck.TrackFore = System.Drawing.Color.Silver;
            // 
            // LoadCarCheck
            // 
            this.LoadCarCheck.Back = null;
            this.LoadCarCheck.BackColor = System.Drawing.Color.Transparent;
            this.LoadCarCheck.BarBack = null;
            this.LoadCarCheck.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.LoadCarCheck.Border = System.Drawing.Color.Transparent;
            this.LoadCarCheck.ForeColor = System.Drawing.Color.Transparent;
            this.LoadCarCheck.Glass = false;
            this.LoadCarCheck.InnerBorder = System.Drawing.Color.Transparent;
            this.LoadCarCheck.Location = new System.Drawing.Point(556, 285);
            this.LoadCarCheck.Name = "LoadCarCheck";
            this.LoadCarCheck.Radius = 1;
            this.LoadCarCheck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.LoadCarCheck.Size = new System.Drawing.Size(323, 30);
            this.LoadCarCheck.TabIndex = 0;
            this.LoadCarCheck.TextFormat = CCWin.SkinControl.SkinProgressBar.TxtFormat.None;
            this.LoadCarCheck.TrackBack = System.Drawing.Color.Black;
            this.LoadCarCheck.TrackFore = System.Drawing.Color.Silver;
            // 
            // RailCleanCarCheck
            // 
            this.RailCleanCarCheck.Back = null;
            this.RailCleanCarCheck.BackColor = System.Drawing.Color.Transparent;
            this.RailCleanCarCheck.BarBack = null;
            this.RailCleanCarCheck.BarRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.RailCleanCarCheck.Border = System.Drawing.Color.Transparent;
            this.RailCleanCarCheck.ForeColor = System.Drawing.Color.Transparent;
            this.RailCleanCarCheck.Glass = false;
            this.RailCleanCarCheck.InnerBorder = System.Drawing.Color.Transparent;
            this.RailCleanCarCheck.Location = new System.Drawing.Point(556, 370);
            this.RailCleanCarCheck.Name = "RailCleanCarCheck";
            this.RailCleanCarCheck.Radius = 1;
            this.RailCleanCarCheck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.RailCleanCarCheck.Size = new System.Drawing.Size(323, 30);
            this.RailCleanCarCheck.TabIndex = 0;
            this.RailCleanCarCheck.TextFormat = CCWin.SkinControl.SkinProgressBar.TxtFormat.None;
            this.RailCleanCarCheck.TrackBack = System.Drawing.Color.Black;
            this.RailCleanCarCheck.TrackFore = System.Drawing.Color.Silver;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // CkeckBtn
            // 
            this.CkeckBtn.BackColor = System.Drawing.Color.Transparent;
            this.CkeckBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CkeckBtn.BackgroundImage")));
            this.CkeckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CkeckBtn.BaseColor = System.Drawing.Color.Transparent;
            this.CkeckBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CkeckBtn.DownBack = null;
            this.CkeckBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.CkeckBtn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CkeckBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CkeckBtn.Image = ((System.Drawing.Image)(resources.GetObject("CkeckBtn.Image")));
            this.CkeckBtn.IsDrawBorder = false;
            this.CkeckBtn.IsDrawGlass = false;
            this.CkeckBtn.Location = new System.Drawing.Point(152, 242);
            this.CkeckBtn.MouseBack = null;
            this.CkeckBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.CkeckBtn.Name = "CkeckBtn";
            this.CkeckBtn.NormlBack = null;
            this.CkeckBtn.Size = new System.Drawing.Size(104, 104);
            this.CkeckBtn.TabIndex = 5;
            this.CkeckBtn.Text = "Check\r\n 自 检";
            this.CkeckBtn.UseVisualStyleBackColor = false;
            this.CkeckBtn.Click += new System.EventHandler(this.CkeckBtn_Click);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.BackgroundImage")));
            this.skinPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPictureBox1.Location = new System.Drawing.Point(42, 71);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(171, 172);
            this.skinPictureBox1.TabIndex = 104;
            this.skinPictureBox1.TabStop = false;
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
            this.HomeBtn.TabIndex = 105;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Black;
            this.skinLabel1.BorderSize = 0;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(916, 201);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(88, 25);
            this.skinLabel1.TabIndex = 106;
            this.skinLabel1.Text = "终端自检";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Black;
            this.skinLabel2.BorderSize = 0;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(916, 284);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(107, 25);
            this.skinLabel2.TabIndex = 107;
            this.skinLabel2.Text = "装载车自检";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.Black;
            this.skinLabel3.BorderSize = 0;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(916, 373);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(145, 25);
            this.skinLabel3.TabIndex = 108;
            this.skinLabel3.Text = "轨道清理车自检";
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
            this.rightBtn.TabIndex = 109;
            this.rightBtn.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.CkeckBtn);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.RailCleanCarCheck);
            this.Controls.Add(this.LoadCarCheck);
            this.Controls.Add(this.TermalCheck);
            this.Name = "CHeckFrm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClearnFrm_FormClosing);
            this.Load += new System.EventHandler(this.ClearnFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinProgressBar LoadCarCheck;
        private CCWin.SkinControl.SkinProgressBar RailCleanCarCheck;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinLabel DataLabel;
        private CCWin.SkinControl.SkinLabel TimeLabel;
        private System.Windows.Forms.Timer RTC;
        private CCWin.SkinControl.SkinButton CkeckBtn;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinButton HomeBtn;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton rightBtn;
        private CCWin.SkinControl.SkinProgressBar TermalCheck;
    }
}