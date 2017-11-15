using System;

namespace CleanSys
{
    partial class Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.DataLabel = new CCWin.SkinControl.SkinLabel();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new CCWin.SkinControl.SkinLabel();
            this.rightBtn = new CCWin.SkinControl.SkinButton();
            this.HomeBtn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
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
            // rightBtn
            // 
            this.rightBtn.BackColor = System.Drawing.Color.Transparent;
            this.rightBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightBtn.BackgroundImage")));
            this.rightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightBtn.BaseColor = System.Drawing.Color.Transparent;
            this.rightBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rightBtn.DownBack = null;
            this.rightBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.rightBtn.GlowColor = System.Drawing.Color.Transparent;
            this.rightBtn.IsDrawBorder = false;
            this.rightBtn.IsDrawGlass = false;
            this.rightBtn.Location = new System.Drawing.Point(1205, 617);
            this.rightBtn.MouseBack = null;
            this.rightBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.NormlBack = null;
            this.rightBtn.Size = new System.Drawing.Size(60, 60);
            this.rightBtn.TabIndex = 110;
            this.rightBtn.UseVisualStyleBackColor = false;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
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
            this.HomeBtn.Location = new System.Drawing.Point(72, 617);
            this.HomeBtn.MouseBack = null;
            this.HomeBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.NormlBack = null;
            this.HomeBtn.Size = new System.Drawing.Size(60, 60);
            this.HomeBtn.TabIndex = 111;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 727);
            this.ControlBox = false;
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.TimeLabel);
            this.MaximizeBox = false;
            this.MdiBackColor = System.Drawing.Color.Transparent;
            this.MinimizeBox = false;
            this.Name = "Helper";
            this.ShadowColor = System.Drawing.Color.Transparent;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Helper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        
        protected CCWin.SkinControl.SkinLabel DataLabel;
        protected System.Windows.Forms.Timer RTC;
        protected CCWin.SkinControl.SkinLabel TimeLabel;
        private CCWin.SkinControl.SkinButton rightBtn;
        private CCWin.SkinControl.SkinButton HomeBtn;
    }
}