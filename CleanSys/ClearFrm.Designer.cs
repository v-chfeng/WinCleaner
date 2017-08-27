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
            this.Clean = new CCWin.SkinControl.SkinButton();
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.boxBtn = new CCWin.SkinControl.SkinButton();
            this.autoBtn = new CCWin.SkinControl.SkinButton();
            this.manualBtn = new CCWin.SkinControl.SkinButton();
            this.Home = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.Transparent;
            this.Clean.BaseColor = System.Drawing.Color.Black;
            this.Clean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Clean.DownBack = null;
            this.Clean.ForeColor = System.Drawing.Color.White;
            this.Clean.Location = new System.Drawing.Point(110, 184);
            this.Clean.MouseBack = null;
            this.Clean.Name = "Clean";
            this.Clean.NormlBack = null;
            this.Clean.Size = new System.Drawing.Size(83, 74);
            this.Clean.TabIndex = 2;
            this.Clean.Text = "清理\r\nClean";
            this.Clean.UseVisualStyleBackColor = false;
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
            this.boxBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.boxBtn.DownBack = null;
            this.boxBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.boxBtn.Location = new System.Drawing.Point(420, 147);
            this.boxBtn.MouseBack = null;
            this.boxBtn.MouseBaseColor = System.Drawing.Color.Black;
            this.boxBtn.Name = "boxBtn";
            this.boxBtn.NormlBack = null;
            this.boxBtn.Size = new System.Drawing.Size(262, 34);
            this.boxBtn.TabIndex = 5;
            this.boxBtn.Text = "箱壁清理";
            this.boxBtn.UseVisualStyleBackColor = false;
            // 
            // autoBtn
            // 
            this.autoBtn.BackColor = System.Drawing.Color.Black;
            this.autoBtn.BaseColor = System.Drawing.Color.Black;
            this.autoBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.autoBtn.DownBack = null;
            this.autoBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.autoBtn.Location = new System.Drawing.Point(420, 207);
            this.autoBtn.MouseBack = null;
            this.autoBtn.MouseBaseColor = System.Drawing.Color.Black;
            this.autoBtn.Name = "autoBtn";
            this.autoBtn.NormlBack = null;
            this.autoBtn.Size = new System.Drawing.Size(262, 32);
            this.autoBtn.TabIndex = 5;
            this.autoBtn.Text = "自动清理";
            this.autoBtn.UseVisualStyleBackColor = false;
            this.autoBtn.Click += new System.EventHandler(this.autoBtn_Click);
            // 
            // manualBtn
            // 
            this.manualBtn.BackColor = System.Drawing.Color.Black;
            this.manualBtn.BaseColor = System.Drawing.Color.Black;
            this.manualBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.manualBtn.DownBack = null;
            this.manualBtn.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.manualBtn.Location = new System.Drawing.Point(420, 269);
            this.manualBtn.MouseBack = null;
            this.manualBtn.MouseBaseColor = System.Drawing.Color.Black;
            this.manualBtn.Name = "manualBtn";
            this.manualBtn.NormlBack = null;
            this.manualBtn.Size = new System.Drawing.Size(262, 31);
            this.manualBtn.TabIndex = 5;
            this.manualBtn.Text = "手动清理";
            this.manualBtn.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Home.DownBack = null;
            this.Home.Location = new System.Drawing.Point(70, 383);
            this.Home.MouseBack = null;
            this.Home.Name = "Home";
            this.Home.NormlBack = null;
            this.Home.Size = new System.Drawing.Size(52, 44);
            this.Home.TabIndex = 6;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
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
            this.Controls.Add(this.Home);
            this.Controls.Add(this.manualBtn);
            this.Controls.Add(this.autoBtn);
            this.Controls.Add(this.boxBtn);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Clean);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ClearFrm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.CleanFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton Clean;
        private CCWin.SkinControl.SkinLabel DataLabel;
        private CCWin.SkinControl.SkinLabel TimeLabel;
        private System.Windows.Forms.Timer RTC;
        private CCWin.SkinControl.SkinButton boxBtn;
        private CCWin.SkinControl.SkinButton autoBtn;
        private CCWin.SkinControl.SkinButton manualBtn;
        private CCWin.SkinControl.SkinButton Home;
    }
}