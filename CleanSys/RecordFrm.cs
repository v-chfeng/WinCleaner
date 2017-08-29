using CCWin;
using CCWin.SkinControl;
using CleanSys.Properties;
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
            this.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("backgroud2")));

            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();

            myColor.checkButton[0, 0] = b11;
            myColor.checkButton[0, 1] = b12;
            myColor.checkButton[0, 2] = b13;
            myColor.checkButton[0, 3] = b14;
            myColor.checkButton[0, 4] = b15;
            myColor.checkButton[0, 5] = b16;
            myColor.checkButton[0, 6] = b17;
            myColor.checkButton[0, 7] = b18;
            myColor.checkButton[1, 0] = b21;
            myColor.checkButton[1, 1] = b22;
            myColor.checkButton[1, 2] = b23;
            myColor.checkButton[1, 3] = b24;
            myColor.checkButton[1, 4] = b25;
            myColor.checkButton[1, 5] = b26;
            myColor.checkButton[1, 6] = b27;
            myColor.checkButton[1, 7] = b28;
            myColor.checkButton[2, 0] = b31;
            myColor.checkButton[2, 1] = b32;
            myColor.checkButton[2, 2] = b33;
            myColor.checkButton[2, 3] = b34;
            myColor.checkButton[2, 4] = b35;
            myColor.checkButton[2, 5] = b36;
            myColor.checkButton[2, 6] = b37;
            myColor.checkButton[2, 7] = b38;
            myColor.checkButton[3, 0] = b41;
            myColor.checkButton[3, 1] = b42;
            myColor.checkButton[3, 2] = b43;
            myColor.checkButton[3, 3] = b44;
            myColor.checkButton[3, 4] = b45;
            myColor.checkButton[3, 5] = b46;
            myColor.checkButton[3, 6] = b47;
            myColor.checkButton[3, 7] = b48;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    myColor.checkButton[i, j].BackColor = myColor.UncheckColor;
                }
            }


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
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
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


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            myData.mainFrm.Visible = true;
            this.Close();
        }

        private void RecordBut_Click(object sender, EventArgs e)
        {
            string RecordData = string.Empty;
            // get  Header info
            RecordData += comboBox1.Text;
            RecordData += "/t" + comboBox2.Text;
            RecordData += "/t" + comboBox3.Text;
            RecordData += "/t" + dateTimePicker1.Text;
            // get  Check info
            RecordData += myColor.GetButtonSt();
            myData.SaveRecord(RecordData);
        }



        private void b21_Click(object sender, EventArgs e)
        {
            if (b21.BackColor == myColor.UncheckColor)
            { b21.BackColor = myColor.Checkcolor; }
            else
            { b21.BackColor = myColor.UncheckColor; }
        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (b22.BackColor == myColor.UncheckColor)
            { b22.BackColor = myColor.Checkcolor; }
            else
            { b22.BackColor = myColor.UncheckColor; }
        }

        private void b23_Click(object sender, EventArgs e)
        {
            if (b23.BackColor == myColor.UncheckColor)
            { b23.BackColor = myColor.Checkcolor; }
            else
            { b23.BackColor = myColor.UncheckColor; }
        }

        private void b24_Click(object sender, EventArgs e)
        {
            if (b24.BackColor == myColor.UncheckColor)
            { b24.BackColor = myColor.Checkcolor; }
            else
            { b24.BackColor = myColor.UncheckColor; }
        }

        private void b25_Click(object sender, EventArgs e)
        {
            if (b25.BackColor == myColor.UncheckColor)
            { b25.BackColor = myColor.Checkcolor; }
            else
            { b25.BackColor = myColor.UncheckColor; }
        }

        private void b26_Click(object sender, EventArgs e)
        {
            if (b26.BackColor == myColor.UncheckColor)
            { b26.BackColor = myColor.Checkcolor; }
            else
            { b26.BackColor = myColor.UncheckColor; }
        }

        private void b27_Click(object sender, EventArgs e)
        {
            if (b27.BackColor == myColor.UncheckColor)
            { b27.BackColor = myColor.Checkcolor; }
            else
            { b27.BackColor = myColor.UncheckColor; }

        }

        private void b28_Click(object sender, EventArgs e)
        {
            if (b28.BackColor == myColor.UncheckColor)
            { b28.BackColor = myColor.Checkcolor; }
            else
            { b28.BackColor = myColor.UncheckColor; }

        }

        private void b31_Click(object sender, EventArgs e)
        {
            if (b31.BackColor == myColor.UncheckColor)
            { b31.BackColor = myColor.Checkcolor; }
            else
            { b31.BackColor = myColor.UncheckColor; }
        }

        private void b32_Click(object sender, EventArgs e)
        {
            if (b32.BackColor == myColor.UncheckColor)
            { b32.BackColor = myColor.Checkcolor; }
            else
            { b32.BackColor = myColor.UncheckColor; }
        }

        private void b33_Click(object sender, EventArgs e)
        {
            if (b33.BackColor == myColor.UncheckColor)
            { b33.BackColor = myColor.Checkcolor; }
            else
            { b33.BackColor = myColor.UncheckColor; }
        }

        private void b34_Click(object sender, EventArgs e)
        {
            if (b34.BackColor == myColor.UncheckColor)
            { b34.BackColor = myColor.Checkcolor; }
            else
            { b34.BackColor = myColor.UncheckColor; }
        }

        private void b35_Click(object sender, EventArgs e)
        {
            if (b35.BackColor == myColor.UncheckColor)
            { b35.BackColor = myColor.Checkcolor; }
            else
            { b35.BackColor = myColor.UncheckColor; }
        }



        private void b36_Click(object sender, EventArgs e)
        {
            if (b36.BackColor == myColor.UncheckColor)
            { b36.BackColor = myColor.Checkcolor; }
            else
            { b36.BackColor = myColor.UncheckColor; }
        }

        private void b37_Click(object sender, EventArgs e)
        {
            if (b37.BackColor == myColor.UncheckColor)
            { b37.BackColor = myColor.Checkcolor; }
            else
            { b37.BackColor = myColor.UncheckColor; }
        }

        private void b38_Click(object sender, EventArgs e)
        {
            if (b38.BackColor == myColor.UncheckColor)
            { b38.BackColor = myColor.Checkcolor; }
            else
            { b38.BackColor = myColor.UncheckColor; }
        }

        private void b41_Click(object sender, EventArgs e)
        {
            if (b41.BackColor == myColor.UncheckColor)
            { b41.BackColor = myColor.Checkcolor; }
            else
            { b41.BackColor = myColor.UncheckColor; }
        }

        private void b42_Click(object sender, EventArgs e)
        {
            if (b42.BackColor == myColor.UncheckColor)
            { b42.BackColor = myColor.Checkcolor; }
            else
            { b42.BackColor = myColor.UncheckColor; }
        }

        private void b43_Click(object sender, EventArgs e)
        {
            if (b43.BackColor == myColor.UncheckColor)
            { b43.BackColor = myColor.Checkcolor; }
            else
            { b43.BackColor = myColor.UncheckColor; }
        }

        private void b44_Click(object sender, EventArgs e)
        {
            if (b44.BackColor == myColor.UncheckColor)
            { b44.BackColor = myColor.Checkcolor; }
            else
            { b44.BackColor = myColor.UncheckColor; }
        }

        private void b45_Click(object sender, EventArgs e)
        {
            if (b45.BackColor == myColor.UncheckColor)
            { b45.BackColor = myColor.Checkcolor; }
            else
            { b45.BackColor = myColor.UncheckColor; }
        }

        private void b46_Click(object sender, EventArgs e)
        {
            if (b46.BackColor == myColor.UncheckColor)
            { b46.BackColor = myColor.Checkcolor; }
            else
            { b46.BackColor = myColor.UncheckColor; }
        }

        private void b47_Click(object sender, EventArgs e)
        {
            if (b47.BackColor == myColor.UncheckColor)
            { b47.BackColor = myColor.Checkcolor; }
            else
            { b47.BackColor = myColor.UncheckColor; }
        }

        private void b48_Click(object sender, EventArgs e)
        {
            if (b48.BackColor == myColor.UncheckColor)
            { b48.BackColor = myColor.Checkcolor; }
            else
            { b48.BackColor = myColor.UncheckColor; }
        }

   
    }
    static class myColor
    {
        public static Color Checkcolor = Color.Green;
        public static Color UncheckColor = Color.Black;
        public static SkinButton[,] checkButton = new SkinButton[4, 8];
        public static string GetButtonSt()
        {
            string st = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                st = st + "/t"+ "N" + System.Convert.ToString(i+1) +"-";
                for (int j = 0; j < 8; j++)
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
