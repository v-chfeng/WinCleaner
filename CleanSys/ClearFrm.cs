using CCWin;
using CleanSys.Properties;
using CleanSys.Util;
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
    public partial class ClearFrm : CCSkinMain
    {
        public ClearFrm()
        {
            InitializeComponent();
        }

        private void CleanFrm_Load(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();

            this.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("backgroud2")));
        }

        private void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
            myData.mainFrm.Visible = true;
            
        }

        private void autoBtn_Click(object sender, EventArgs e)
        {
            AutoCleanFrm clearFrm = new AutoCleanFrm();
          //  clearFrm.StartPosition = FormStartPosition.Manual;
          //   clearFrm.Location = this.Location;
            myData.frmStack.Push(this);
            clearFrm.Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            myData.mainFrm.Visible = true;
            this.Close();
        }

        private void manualBtn_Click(object sender, EventArgs e)
        {
            myData.frmStack.Push(this);
            ManualCleanFrm manualFrm = new ManualCleanFrm();
            manualFrm.Show();
            this.Hide();
        }
    }
}
