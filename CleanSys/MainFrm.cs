using CCWin;
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
    //Skin_Color，Skin_DevExpress，Skin_Mac，Skin_Metro，Skin_VS,CCSkinMain
    public partial class FrmMain : CCSkinMain
    {
        public object setLocation { get; private set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            myData.myPossition = new Size(x, y);
            this.Location = (Point)myData.myPossition;         //窗体的起始位置为(x,y)
            myData.mainFrm = this;
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
           // CheckButton.Location = (Point)new Size((x+ System.Windows.Forms.SystemInformation.WorkingArea.Width - CheckButton.Size.Width )/ 7*2, (y+ System.Windows.Forms.SystemInformation.WorkingArea.Height - CheckButton.Size.Height )/ 7*2);
            //Help.Location= (Point)new Size((x + System.Windows.Forms.SystemInformation.WorkingArea.Width - Help.Size.Width) / 7*2, (y + System.Windows.Forms.SystemInformation.WorkingArea.Height - Help.Size.Height )/ 7*5);
            //CleanButton.Location = (Point)new Size((x + System.Windows.Forms.SystemInformation.WorkingArea.Width - CleanButton.Size.Width) / 7*5,( y + System.Windows.Forms.SystemInformation.WorkingArea.Height - CleanButton.Size.Height )/ 7*2);
           // RecordButton.Location= (Point)new Size((x + System.Windows.Forms.SystemInformation.WorkingArea.Width - RecordButton.Size.Width) / 7*5, (y + System.Windows.Forms.SystemInformation.WorkingArea.Height - RecordButton.Size.Height )/ 7*5);
            skinPictureBox1.Location = (Point)new Size((this.Size.Width - skinPictureBox1.Size.Width)/2, (this.Size.Height -skinPictureBox1.Size.Height)/2 );

            this.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("backgroud2")));
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            CHeckFrm checkFrm = new CHeckFrm();
            checkFrm.StartPosition = FormStartPosition.Manual;
            checkFrm.Location = this.Location;
            checkFrm.Show();
            this.Hide();
        }

        private void RTC_Tick(object sender, EventArgs e)
        {

            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            RecordFrm recordFrm = new RecordFrm();
            this.Hide();
            recordFrm.StartPosition = FormStartPosition.Manual;
            recordFrm.Location = this.Location;
            recordFrm.Show();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
           
        }

        private void DataLabel_Click(object sender, EventArgs e)
        {

        }

        private void CleanButton_Click_1(object sender, EventArgs e)
        {
            
            ClearFrm clearFrm = new ClearFrm();
            clearFrm.StartPosition = FormStartPosition.Manual;
            clearFrm.Location = this.Location;
            clearFrm.Show();
            this.Hide();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordFrm recordFrm = new RecordFrm();
           
            recordFrm.StartPosition = FormStartPosition.Manual;
            recordFrm.Location = this.Location;
            recordFrm.Show();
            this.Hide();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
           
            helper.StartPosition = FormStartPosition.Manual;
            helper.Location = this.Location;
            helper.Show();
            this.Hide();
        }

        private void skinPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
