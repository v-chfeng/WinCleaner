using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Galil
{
    public partial class Form1 : Form
    {
        Galil.Galil g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                g = new Galil.Galil(); //create a new object
                label1.Text = g.libraryVersion() + Environment.NewLine; //print libarary version
                g.address = ""; //connect to controller
                label1.Text += g.connection() + Environment.NewLine; //print connection in label1
                label1.Text += "MG TIME " + g.command("MG TIME");
            }
            catch(System.Runtime.InteropServices.COMException ex)
            {
                label1.Text += ex.Message;
            }
        }
    }
}
