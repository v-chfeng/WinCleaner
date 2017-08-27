namespace MyControl
{
    partial class EightAngle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EightAngle));
            this.img1 = new CCWin.SkinControl.SkinPictureBox();
            this.img2 = new CCWin.SkinControl.SkinPictureBox();
            this.img3 = new CCWin.SkinControl.SkinPictureBox();
            this.img4 = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.BackColor = System.Drawing.Color.Transparent;
            this.img1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img1.BackgroundImage")));
            this.img1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img1.Location = new System.Drawing.Point(29, 122);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(62, 62);
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.BackColor = System.Drawing.Color.Transparent;
            this.img2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img2.BackgroundImage")));
            this.img2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img2.Location = new System.Drawing.Point(124, 120);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(61, 64);
            this.img2.TabIndex = 1;
            this.img2.TabStop = false;
            // 
            // img3
            // 
            this.img3.BackColor = System.Drawing.Color.Transparent;
            this.img3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img3.BackgroundImage")));
            this.img3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img3.Location = new System.Drawing.Point(123, 27);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(62, 64);
            this.img3.TabIndex = 2;
            this.img3.TabStop = false;
            // 
            // img4
            // 
            this.img4.BackColor = System.Drawing.Color.Transparent;
            this.img4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img4.BackgroundImage")));
            this.img4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img4.Location = new System.Drawing.Point(29, 27);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(62, 64);
            this.img4.TabIndex = 3;
            this.img4.TabStop = false;
            // 
            // EightAngle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.DoubleBuffered = true;
            this.Name = "EightAngle";
            this.Size = new System.Drawing.Size(214, 214);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox img1;
        private CCWin.SkinControl.SkinPictureBox img2;
        private CCWin.SkinControl.SkinPictureBox img3;
        private CCWin.SkinControl.SkinPictureBox img4;
    }
}
