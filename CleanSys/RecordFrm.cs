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
    public partial class RecordFrm : CCSkinMain
    {
        public RecordFrm()
        {
            InitializeComponent();
        }

        private void RecordFrm_Load(object sender, EventArgs e)
        {
            DataLabel.Text = DateTime.Now.ToLongDateString().ToString() + "   " + DateTime.Now.DayOfWeek.ToString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString().ToString();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (b11.BackColor == Color.Black)
            { b11.BackColor = Color.OrangeRed; }
            else
            { b11.BackColor = Color.Black; }
            
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.BackColor == Color.Black)
            { b12.BackColor = Color.OrangeRed; }
            else
            { b12.BackColor = Color.Black; }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (b13.BackColor == Color.Black)
            { b13.BackColor = Color.OrangeRed; }
            else
            { b13.BackColor = Color.Black; }
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (b14.BackColor == Color.Black)
            { b14.BackColor = Color.OrangeRed; }
            else
            { b14.BackColor = Color.Black; }
        }

        private void b15_Click(object sender, EventArgs e)
        {
            if (b15.BackColor == Color.Black)
            { b15.BackColor = Color.OrangeRed; }
            else
            { b15.BackColor = Color.Black; }
        }

        private void b16_Click(object sender, EventArgs e)
        {
            if (b16.BackColor == Color.Black)
            { b16.BackColor = Color.OrangeRed; }
            else
            { b16.BackColor = Color.Black; }
        }

        private void b17_Click(object sender, EventArgs e)
        {
            if (b17.BackColor == Color.Black)
            { b17.BackColor = Color.OrangeRed; }
            else
            { b17.BackColor = Color.Black; }
        }

        private void b18_Click(object sender, EventArgs e)
        {
            if (b18.BackColor == Color.Black)
            { b18.BackColor = Color.OrangeRed; }
            else
            { b18.BackColor = Color.Black; }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            myData.mainFrm.Visible = true;
            this.Close();
        }

        private void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = DateTime.Now.ToLongDateString().ToString() + "   " + DateTime.Now.DayOfWeek.ToString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString().ToString();
        }
    }
}
