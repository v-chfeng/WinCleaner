namespace CleanSys
{
    partial class AutoCleanFrm
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
            this.AutoClean = new CCWin.SkinControl.SkinButton();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // AutoClean
            // 
            this.AutoClean.BackColor = System.Drawing.Color.Transparent;
            this.AutoClean.BaseColor = System.Drawing.Color.Black;
            this.AutoClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AutoClean.DownBack = null;
            this.AutoClean.ForeColor = System.Drawing.Color.White;
            this.AutoClean.Location = new System.Drawing.Point(70, 100);
            this.AutoClean.MouseBack = null;
            this.AutoClean.Name = "AutoClean";
            this.AutoClean.NormlBack = null;
            this.AutoClean.Size = new System.Drawing.Size(83, 74);
            this.AutoClean.TabIndex = 2;
            this.AutoClean.Text = "自动\r\n\r\n清理";
            this.AutoClean.UseVisualStyleBackColor = false;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(313, 227);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.ProgressWidth = 15;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("宋体", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(94, 92);
            this.circularProgressBar1.StartAngle = 0;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // AutoCleanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.ControlBox = false;
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.AutoClean);
            this.Name = "AutoCleanFrm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.AutoCleanFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton AutoClean;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}