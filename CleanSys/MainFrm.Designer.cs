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
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.CleanButton = new CCWin.SkinControl.SkinButton();
            this.CheckButton = new CCWin.SkinControl.SkinButton();
            this.RecordButton = new CCWin.SkinControl.SkinButton();
            this.Help = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataLabel
            // 
            this.DataLabel.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataLabel.BorderColor = System.Drawing.Color.Transparent;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(1225, 13);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(83, 19);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "skinLabel1";
            // 
            // CleanButton
            // 
            this.CleanButton.BackColor = System.Drawing.Color.Transparent;
            this.CleanButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CleanButton.BackgroundImage")));
            this.CleanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleanButton.BaseColor = System.Drawing.Color.Transparent;
            this.CleanButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CleanButton.DownBack = null;
            this.CleanButton.DownBaseColor = System.Drawing.Color.Transparent;
            this.CleanButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CleanButton.ForeColor = System.Drawing.Color.Transparent;
            this.CleanButton.Image = ((System.Drawing.Image)(resources.GetObject("CleanButton.Image")));
            this.CleanButton.IsDrawBorder = false;
            this.CleanButton.IsDrawGlass = false;
            this.CleanButton.Location = new System.Drawing.Point(872, 177);
            this.CleanButton.MouseBack = null;
            this.CleanButton.MouseBaseColor = System.Drawing.Color.Transparent;
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.NormlBack = null;
            this.CleanButton.Size = new System.Drawing.Size(104, 104);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = " 清 理  \r\nClean";
            this.CleanButton.UseVisualStyleBackColor = false;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click_1);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckButton.BackgroundImage")));
            this.CheckButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckButton.BaseColor = System.Drawing.Color.Transparent;
            this.CheckButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CheckButton.DownBack = null;
            this.CheckButton.DownBaseColor = System.Drawing.Color.Transparent;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckButton.ForeColor = System.Drawing.Color.Transparent;
            this.CheckButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckButton.Image")));
            this.CheckButton.IsDrawBorder = false;
            this.CheckButton.IsDrawGlass = false;
            this.CheckButton.Location = new System.Drawing.Point(389, 177);
            this.CheckButton.MouseBack = null;
            this.CheckButton.MouseBaseColor = System.Drawing.Color.Transparent;
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.NormlBack = null;
            this.CheckButton.Size = new System.Drawing.Size(104, 104);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = " 自 检\r\nCheck";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.BackColor = System.Drawing.Color.Transparent;
            this.RecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecordButton.BackgroundImage")));
            this.RecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecordButton.BaseColor = System.Drawing.Color.Transparent;
            this.RecordButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.RecordButton.DownBack = null;
            this.RecordButton.DownBaseColor = System.Drawing.Color.Transparent;
            this.RecordButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecordButton.ForeColor = System.Drawing.Color.Transparent;
            this.RecordButton.Image = ((System.Drawing.Image)(resources.GetObject("RecordButton.Image")));
            this.RecordButton.IsDrawBorder = false;
            this.RecordButton.IsDrawGlass = false;
            this.RecordButton.Location = new System.Drawing.Point(872, 453);
            this.RecordButton.MouseBack = null;
            this.RecordButton.MouseBaseColor = System.Drawing.Color.Transparent;
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.NormlBack = null;
            this.RecordButton.Size = new System.Drawing.Size(104, 104);
            this.RecordButton.TabIndex = 5;
            this.RecordButton.Text = "记 录\r\nRecord";
            this.RecordButton.UseVisualStyleBackColor = false;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Help.BackgroundImage")));
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help.BaseColor = System.Drawing.Color.Transparent;
            this.Help.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Help.DownBack = null;
            this.Help.DownBaseColor = System.Drawing.Color.Transparent;
            this.Help.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Help.ForeColor = System.Drawing.Color.Transparent;
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.IsDrawBorder = false;
            this.Help.IsDrawGlass = false;
            this.Help.Location = new System.Drawing.Point(389, 453);
            this.Help.MouseBack = null;
            this.Help.MouseBaseColor = System.Drawing.Color.Transparent;
            this.Help.Name = "Help";
            this.Help.NormlBack = null;
            this.Help.Size = new System.Drawing.Size(104, 104);
            this.Help.TabIndex = 6;
            this.Help.Text = "帮 助\r\nHelp";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(491, 212);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(383, 303);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox1.TabIndex = 7;
            this.skinPictureBox1.TabStop = false;
            this.skinPictureBox1.Click += new System.EventHandler(this.skinPictureBox1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 727);
            this.ControlBox = false;
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.CleanButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel DataLabel;
        private System.Windows.Forms.Timer RTC;
        private CCWin.SkinControl.SkinLabel TimeLabel;
        private CCWin.SkinControl.SkinButton CleanButton;
        private CCWin.SkinControl.SkinButton CheckButton;
        private CCWin.SkinControl.SkinButton RecordButton;
        private CCWin.SkinControl.SkinButton Help;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
    }
}

