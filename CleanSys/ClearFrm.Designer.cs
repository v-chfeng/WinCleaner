namespace CleanSys
{
    partial class ClearFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearFrm));
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.boxBtn = new CCWin.SkinControl.SkinButton();
            this.autoBtn = new CCWin.SkinControl.SkinButton();
            this.manualBtn = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.CleanBtn = new CCWin.SkinControl.SkinButton();
            this.HomeBtn = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // boxBtn
            // 
            this.boxBtn.BackColor = System.Drawing.Color.Black;
            this.boxBtn.BaseColor = System.Drawing.Color.Black;
            this.boxBtn.BorderColor = System.Drawing.Color.Black;
            this.boxBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.boxBtn.DownBack = null;
            this.boxBtn.DownBaseColor = System.Drawing.Color.Black;
            this.boxBtn.Location = new System.Drawing.Point(513, 195);
            this.boxBtn.MouseBack = null;
            this.boxBtn.MouseBaseColor = System.Drawing.Color.Black;
            this.boxBtn.Name = "boxBtn";
            this.boxBtn.NormlBack = null;
            this.boxBtn.Size = new System.Drawing.Size(262, 40);
            this.boxBtn.TabIndex = 5;
            this.boxBtn.Text = "箱壁清理";
            this.boxBtn.UseVisualStyleBackColor = false;
            // 
            // autoBtn
            // 
            this.autoBtn.BackColor = System.Drawing.Color.Black;
            this.autoBtn.BaseColor = System.Drawing.Color.Black;
            this.autoBtn.BorderColor = System.Drawing.Color.Black;
            this.autoBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.autoBtn.DownBack = null;
            this.autoBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoBtn.Location = new System.Drawing.Point(513, 305);
            this.autoBtn.MouseBack = null;
            this.autoBtn.MouseBaseColor = System.Drawing.Color.Black;
            this.autoBtn.Name = "autoBtn";
            this.autoBtn.NormlBack = null;
            this.autoBtn.Size = new System.Drawing.Size(262, 40);
            this.autoBtn.TabIndex = 5;
            this.autoBtn.Text = "自动清理";
            this.autoBtn.UseVisualStyleBackColor = false;
            this.autoBtn.Click += new System.EventHandler(this.autoBtn_Click);
            // 
            // manualBtn
            // 
            this.manualBtn.BackColor = System.Drawing.Color.Black;
            this.manualBtn.BaseColor = System.Drawing.Color.Black;
            this.manualBtn.BorderColor = System.Drawing.Color.Black;
            this.manualBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.manualBtn.DownBack = null;
            this.manualBtn.DownBaseColor = System.Drawing.Color.Black;
            this.manualBtn.Location = new System.Drawing.Point(513, 415);
            this.manualBtn.MouseBack = null;
            this.manualBtn.MouseBaseColor = System.Drawing.Color.Black;
            this.manualBtn.Name = "manualBtn";
            this.manualBtn.NormlBack = null;
            this.manualBtn.Size = new System.Drawing.Size(262, 40);
            this.manualBtn.TabIndex = 5;
            this.manualBtn.Text = "手动清理";
            this.manualBtn.UseVisualStyleBackColor = false;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.BackgroundImage")));
            this.skinPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPictureBox1.Location = new System.Drawing.Point(42, 71);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(171, 172);
            this.skinPictureBox1.TabIndex = 105;
            this.skinPictureBox1.TabStop = false;
            // 
            // CleanBtn
            // 
            this.CleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.CleanBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CleanBtn.BackgroundImage")));
            this.CleanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleanBtn.BaseColor = System.Drawing.Color.Transparent;
            this.CleanBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CleanBtn.DownBack = null;
            this.CleanBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.CleanBtn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CleanBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CleanBtn.Image = ((System.Drawing.Image)(resources.GetObject("CleanBtn.Image")));
            this.CleanBtn.IsDrawBorder = false;
            this.CleanBtn.IsDrawGlass = false;
            this.CleanBtn.Location = new System.Drawing.Point(152, 242);
            this.CleanBtn.MouseBack = null;
            this.CleanBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.NormlBack = null;
            this.CleanBtn.Size = new System.Drawing.Size(104, 104);
            this.CleanBtn.TabIndex = 106;
            this.CleanBtn.Text = " 清 理 \r\nClean";
            this.CleanBtn.UseVisualStyleBackColor = false;
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
            this.HomeBtn.TabIndex = 107;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ClearFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 727);
            this.ControlBox = false;
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.manualBtn);
            this.Controls.Add(this.autoBtn);
            this.Controls.Add(this.boxBtn);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TimeLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ClearFrm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.CleanFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel DataLabel;
        private CCWin.SkinControl.SkinLabel TimeLabel;
        private System.Windows.Forms.Timer RTC;
        private CCWin.SkinControl.SkinButton boxBtn;
        private CCWin.SkinControl.SkinButton autoBtn;
        private CCWin.SkinControl.SkinButton manualBtn;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinButton CleanBtn;
        private CCWin.SkinControl.SkinButton HomeBtn;
    }
}