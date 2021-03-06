﻿using CCWin;
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
    public partial class CHeckFrm : CCSkinMain
    {
        public CHeckFrm()
        {
            InitializeComponent();
        }

        private void ClearnFrm_Load(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
            //TermalCheck.Maximum = 100;
            //LoadCarCheck.Minimum = 100;
            //RailCleanCarCheck.Minimum = 100;
            TermalCheck.Value = 0;
            LoadCarCheck.Value = 0;
            RailCleanCarCheck.Value = 0;

            this.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("backgroud2")));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TermalCheck.Value < TermalCheck.Maximum)
            {
                TermalCheck.Value++;
            }
            else
            {
            }
            if (LoadCarCheck.Value < TermalCheck.Maximum)
            {
                LoadCarCheck.Value+=2;
            }
            else
            {
            }
            if (RailCleanCarCheck.Value < TermalCheck.Maximum)
            {
                RailCleanCarCheck.Value+=4;
            }
            else
            {
            }

        }

        private void Check_Click(object sender, EventArgs e)
        {

           timer1.Enabled= true;
        }

        private void ClearnFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Home_Click(object sender, EventArgs e)
        { 
            myData.mainFrm.Visible=true;
            this.Close();
        }

        private void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            myData.mainFrm.Visible = true;
            this.Close();
        }

        private void CkeckBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            myData.mainFrm.Show();
            this.Close();
        }
    }
}
