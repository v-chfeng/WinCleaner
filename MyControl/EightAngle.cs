using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    public partial class EightAngle : UserControl
    {
        private List<CCWin.SkinControl.SkinPictureBox> list;

        public EightAngle()
        {
            this.list = null;
            InitializeComponent();
        }

        public List<CCWin.SkinControl.SkinPictureBox> ImgList
        {
            get
            {
                if (this.list == null)
                {
                    this.list = new List<CCWin.SkinControl.SkinPictureBox>();
                    list.Add(img1);
                    list.Add(img2);
                    list.Add(img3);
                    list.Add(img4);
                }

                return this.list;
            }
        }

        public CCWin.SkinControl.SkinPictureBox ImgOne
        {
            get
            {
                return this.img1;
            }
        }

        public CCWin.SkinControl.SkinPictureBox ImgTwo
        {
            get
            {
                return this.img2;
            }
        }

        public CCWin.SkinControl.SkinPictureBox ImgThree
        {
            get
            {
                return this.img3;
            }
        }

        public CCWin.SkinControl.SkinPictureBox ImgFour
        {
            get
            {
                return this.img4;
            }
        }

        private void img1_Click(object sender, EventArgs e)
        {

        }
    }
}
