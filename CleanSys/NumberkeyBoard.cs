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

    public partial class NumberkeyBoard  : CCSkinMain  
    {
        public NumberkeyBoard()
        {
            InitializeComponent();
        }

        private void NumberkeyBoard_Load(object sender, EventArgs e)
        {

        }

        private void NO1_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "1";
        }

        private void NO2_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "2";
        }

        private void NO3_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "3";
        }

        private void NO4_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "4";
        }

        private void NO5_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "5";
        }

        private void NO6_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "6";
        }

        private void NO7_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "7";
        }
        private void NO8_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "8";
        }

        private void NO9_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "9";
        }

        private void NO0_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += "0";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text += ".";
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            RecordData.EditButton.Text = "";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
