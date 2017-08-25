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
            DataLabel.Text = DateTime.Now.ToLongDateString().ToString() + "   " + DateTime.Now.DayOfWeek.ToString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString().ToString();
        }

        private void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = DateTime.Now.ToLongDateString().ToString() + "   " + DateTime.Now.DayOfWeek.ToString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString().ToString();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
            myData.mainFrm.Visible = true;
            
        }
    }
}
