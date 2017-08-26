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

        private void skinButton1_Click(object sender, EventArgs e)
        {
            AutoCleanFrm clearFrm = new AutoCleanFrm();
            this.Hide();
            clearFrm.StartPosition = FormStartPosition.Manual;
            clearFrm.Location = this.Location;
            clearFrm.Show();
        }
    }
}
