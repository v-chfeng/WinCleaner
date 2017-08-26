using CCWin;
using CCWin.SkinControl;
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

            myColor.checkButton[0, 0] = b11;
            myColor.checkButton[0, 1] = b12;
            myColor.checkButton[0, 2] = b13;
            myColor.checkButton[0, 3] = b14;
            myColor.checkButton[0, 4] = b15;
            myColor.checkButton[0, 5] = b16;
            myColor.checkButton[0, 6] = b17;
            myColor.checkButton[0, 7] = b18;
            


        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (b11.BackColor == myColor.UncheckColor)
            { b11.BackColor = myColor.Checkcolor; }
            else
            { b11.BackColor = myColor.UncheckColor; }
            
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.BackColor == myColor.UncheckColor)
            { b12.BackColor = myColor.Checkcolor; }
            else
            { b12.BackColor = myColor.UncheckColor; }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (b13.BackColor == myColor.UncheckColor)
            { b13.BackColor = myColor.Checkcolor; }
            else
            { b13.BackColor = myColor.UncheckColor; }
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (b14.BackColor == myColor.UncheckColor)
            { b14.BackColor = myColor.Checkcolor; }
            else
            { b14.BackColor = myColor.UncheckColor; }
        }

        private void b15_Click(object sender, EventArgs e)
        {
            if (b15.BackColor == myColor.UncheckColor)
            { b15.BackColor = myColor.Checkcolor; }
            else
            { b15.BackColor = myColor.UncheckColor; }
        }

        private void b16_Click(object sender, EventArgs e)
        {
            if (b16.BackColor == myColor.UncheckColor)
            { b16.BackColor = myColor.Checkcolor; }
            else
            { b16.BackColor = myColor.UncheckColor; }
        }

        private void b17_Click(object sender, EventArgs e)
        {
            if (b17.BackColor == myColor.UncheckColor)
            { b17.BackColor = myColor.Checkcolor; }
            else
            { b17.BackColor = myColor.UncheckColor; }
        }

        private void b18_Click(object sender, EventArgs e)
        {
            if (b18.BackColor == myColor.UncheckColor)
            { b18.BackColor = myColor.Checkcolor; }
            else
            { b18.BackColor = myColor.UncheckColor; }
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

        private void Record_Click(object sender, EventArgs e)
        {
            string RecordData = string.Empty;
            // get  Header info
            RecordData += comboBox1.Text;
            RecordData += "/t" + comboBox2.Text;
            RecordData += "/t" + comboBox3.Text;
            RecordData += "/t" + dateTimePicker1.Text;
            // get  Check info
            RecordData += myColor.GetButtonSt();

        }

        private void b21_Click(object sender, EventArgs e)
        {

        }
    }
    static class myColor
    {
        public static Color Checkcolor = Color.Black;
        public static Color UncheckColor = Color.Green;
        public static SkinButton[,] checkButton = new SkinButton[4, 8];
        public static string GetButtonSt()
        {
            string st = string.Empty;
            for (int i = 0; i < 1; i++)
            {
                st = st + "/t"+ "N" + System.Convert.ToString(i+1) +"-";
                for (int j = 7; j >= 0; j--)
                {
                    if (checkButton[i, j].BackColor == myColor.Checkcolor)
                    { st += "1"; }
                    else
                    { st += "0"; }
                }
            }
            return st;
        }
    }

}
