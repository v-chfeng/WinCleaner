namespace CleanSys
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.CheckButton = new CCWin.SkinControl.SkinButton();
            this.HelpBtn = new CCWin.SkinControl.SkinButton();
            this.CleanButton = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckButton.BaseColor = System.Drawing.Color.Black;
            this.CheckButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CheckButton.DownBack = null;
            this.CheckButton.ForeColor = System.Drawing.Color.White;
            this.CheckButton.Location = new System.Drawing.Point(175, 105);
            this.CheckButton.MouseBack = null;
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.NormlBack = null;
            this.CheckButton.Size = new System.Drawing.Size(83, 74);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = " 自检\r\nCheck";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // HelpButton
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.BaseColor = System.Drawing.Color.Black;
            this.HelpBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HelpBtn.DownBack = null;
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Location = new System.Drawing.Point(175, 303);
            this.HelpBtn.MouseBack = null;
            this.HelpBtn.Name = "HelpButton";
            this.HelpBtn.NormlBack = null;
            this.HelpBtn.Size = new System.Drawing.Size(83, 74);
            this.HelpBtn.TabIndex = 0;
            this.HelpBtn.Text = "帮助\r\nHelp";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.BackColor = System.Drawing.Color.Transparent;
            this.CleanButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CleanButton.BackgroundImage")));
            this.CleanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleanButton.BaseColor = System.Drawing.Color.Transparent;
            this.CleanButton.BorderColor = System.Drawing.Color.Transparent;
            this.CleanButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CleanButton.DownBack = null;
            this.CleanButton.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.CleanButton.FadeGlow = false;
            this.CleanButton.ForeColor = System.Drawing.Color.White;
            this.CleanButton.InnerBorderColor = System.Drawing.Color.Transparent;
            this.CleanButton.IsDrawBorder = false;
            this.CleanButton.Location = new System.Drawing.Point(551, 105);
            this.CleanButton.MouseBack = null;
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.NormlBack = null;
            this.CleanButton.Size = new System.Drawing.Size(83, 74);
            this.CleanButton.TabIndex = 0;
            this.CleanButton.Text = "清理\r\nClean";
            this.CleanButton.UseVisualStyleBackColor = false;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.Black;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.ForeColor = System.Drawing.Color.White;
            this.skinButton2.Location = new System.Drawing.Point(551, 303);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(83, 74);
            this.skinButton2.TabIndex = 0;
            this.skinButton2.Text = " 记录 \r\nRecord";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataLabel.BorderColor = System.Drawing.Color.Transparent;
            this.DataLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataLabel.ForeColor = System.Drawing.Color.Black;
            this.DataLabel.Location = new System.Drawing.Point(616, 13);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(83, 19);
            this.DataLabel.TabIndex = 1;
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
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(1225, 13);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(83, 19);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "skinLabel1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 727);
            this.ControlBox = false;
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TimeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShadowColor = System.Drawing.Color.Transparent;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton CheckButton;
        private CCWin.SkinControl.SkinButton HelpBtn;
        private CCWin.SkinControl.SkinButton CleanButton;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinLabel DataLabel;
        private System.Windows.Forms.Timer RTC;
        private CCWin.SkinControl.SkinLabel TimeLabel;
    }
}

