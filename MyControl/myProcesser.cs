using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanSys
{
    public partial class myProcesser : UserControl
    {
        public myProcesser()
        {
            InitializeComponent();
        }

        public CircularProgressBar.CircularProgressBar ProcessBar
        {
            get
            {
                return this.process1;
            }
        }
    }
}
