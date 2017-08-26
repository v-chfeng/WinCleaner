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
            this.b11 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
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
            // RTC
            // 
            this.RTC.Enabled = true;
            this.RTC.Interval = 1000;
            this.RTC.Tick += new System.EventHandler(this.RTC_Tick);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.Black;
            this.b11.BaseColor = System.Drawing.Color.Black;
            this.b11.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.b11.DownBack = null;
            this.b11.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.b11.Location = new System.Drawing.Point(420, 147);
            this.b11.MouseBack = null;
            this.b11.MouseBaseColor = System.Drawing.Color.Black;
            this.b11.Name = "b11";
            this.b11.NormlBack = null;
            this.b11.Size = new System.Drawing.Size(262, 34);
            this.b11.TabIndex = 5;
            this.b11.Text = "箱壁清理";
            this.b11.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Black;
            this.skinButton1.BaseColor = System.Drawing.Color.Black;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.skinButton1.Location = new System.Drawing.Point(420, 207);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.Black;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(262, 32);
            this.skinButton1.TabIndex = 5;
            this.skinButton1.Text = "自动清理";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Black;
            this.skinButton2.BaseColor = System.Drawing.Color.Black;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.skinButton2.Location = new System.Drawing.Point(420, 269);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.Black;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(262, 31);
            this.skinButton2.TabIndex = 5;
            this.skinButton2.Text = "手动清理";
            this.skinButton2.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.b11);
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
        private CCWin.SkinControl.SkinButton b11;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton Home;
    }
}