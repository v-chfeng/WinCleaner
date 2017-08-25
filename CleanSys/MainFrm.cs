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
            DataLabel.Text = DateTime.Now.ToLongDateString().ToString() + "   " + DateTime.Now.DayOfWeek.ToString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString().ToString();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            ClearFrm clearFrm = new ClearFrm();
            this.Hide();
            clearFrm.StartPosition = FormStartPosition.Manual;
            clearFrm.Location = this.Location;
            clearFrm.Show();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            CHeckFrm checkFrm = new CHeckFrm();
            this.Hide();
            checkFrm.StartPosition = FormStartPosition.Manual;
            checkFrm.Location = this.Location;
            checkFrm.Show();
        }

        private void RTC_Tick(object sender, EventArgs e)
        {

            DataLabel.Text = DateTime.Now.ToLongDateString().ToString()+"   " + DateTime.Now.DayOfWeek.ToString();
            TimeLabel.Text = DateTime.Now.ToShortTimeString().ToString();
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
            Helper helper = new Helper();
            this.Hide();
            helper.StartPosition = FormStartPosition.Manual;
            helper.Location = this.Location;
            helper.Show();
        }
    }
}
