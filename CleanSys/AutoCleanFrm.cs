using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanSys
{
    public partial class AutoCleanFrm : CCSkinMain
    {
        private string spendTimeTemplate = @"用时: {0}";
        private DateTime startTime1;
        private DateTime startTime2;
        private DateTime startTime3;

        public AutoCleanFrm()
        {
            InitializeComponent();
        }

        private void AutoCleanFrm_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            myData.myPossition = new Size(x, y);
            this.Location = (Point)myData.myPossition;         //窗体的起始位置为(x,y)
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }

        protected void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
            testProcess();
        }

        private void testProcess()
        {
            this.process1.ProcessBar.Increment(90);// 环形进度条 增加百分比
            this.process2.ProcessBar.Increment(90);// 环形进度条 增加百分比
            this.process3.ProcessBar.Increment(90);// 环形进度条 增加百分比

            this.spendTime1.Text = "用时";
        }

        private void process2_Click(object sender, EventArgs e)
        {

        }

        private void AutoClean_Click(object sender, EventArgs e)
        {
            // 发送 自动清理请求到 清理机器

            //

            // 进度条开始动

            // 灯开始亮
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            ;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            myData.mainFrm.Show();// show();
            myData.frmStack.Clear();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form backFrm = myData.frmStack.Pop();
            backFrm.Show();
        }

        //private void string 
    }
}
