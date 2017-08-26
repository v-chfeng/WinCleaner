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
    public partial class formTemplate : CCSkinMain
    {
        public object setLocation { get; private set; }

        public formTemplate()
        {
            InitializeComponent();
        }

        protected void initLoad(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            myData.myPossition = new Size(x, y);
            this.Location = (Point)myData.myPossition;         //窗体的起始位置为(x,y)
            myData.mainFrm = this;
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }

        protected void RTC_Tick(object sender, EventArgs e)
        {

            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }
    }
}
