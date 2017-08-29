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
        public EightAngle()
        {
            InitializeComponent();
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
    }
}
