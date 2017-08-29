namespace CleanSys
{
    partial class myProcesser
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myProcesser));
            this.process1 = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.process1.AnimationSpeed = 500;
            this.process1.BackColor = System.Drawing.Color.Transparent;
            this.process1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.process1.ForeColor = System.Drawing.Color.White;
            this.process1.InnerColor = System.Drawing.Color.Transparent;
            this.process1.InnerMargin = 2;
            this.process1.InnerWidth = -1;
            this.process1.Location = new System.Drawing.Point(0, -1);
            this.process1.MarqueeAnimationSpeed = 2000;
            this.process1.Name = "process1";
            this.process1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.process1.OuterMargin = -25;
            this.process1.OuterWidth = 25;
            this.process1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(118)))), ((int)(((byte)(89)))));
            this.process1.ProgressWidth = 15;
            this.process1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.process1.SecondaryFont = new System.Drawing.Font("宋体", 36F);
            this.process1.Size = new System.Drawing.Size(100, 100);
            this.process1.StartAngle = -90;
            this.process1.Step = 1;
            this.process1.SubscriptColor = System.Drawing.Color.Gray;
            this.process1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.process1.SubscriptText = "";
            this.process1.SuperscriptColor = System.Drawing.Color.Gray;
            this.process1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.process1.SuperscriptText = "";
            this.process1.TabIndex = 100;
            this.process1.Text = "40%";
            this.process1.TextMargin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.process1.Value = 68;
            // 
            // myProcesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.process1);
            this.DoubleBuffered = true;
            this.Name = "myProcesser";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar process1;
    }
}
