using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Driven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Galil.Galil g = new Galil.Galil(); //Dimension g variable for instantiated object

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                g.address = ""; //connect to controller
                this.Text = g.connection(); //print connection information to form titlebar

                //UI is supported on DMC40x0, DMC41x3, DMC18x6, DMC18x2, DMC30010
                //if controller does not support UI, leave UIi out of the program

                //download asynchronous message progam
                g.programDownload("i=0\rMG\"Message\",i;WT100;UIi;i=i+1;JP1");

                g.command("XQ"); //start the asynchronous message program
                g.recordsStart(100); //start records argument is period in ms

                g.onRecord += new Galil.Events_onRecordEventHandler(g_onRecord); //bing record event
                g.onMessage += new Galil.Events_onMessageEventHandler(g_onMessage); //bind message event
                g.onInterrupt += new Galil.Events_onInterruptEventHandler(g_onInterrupt); //bind interrupt event
            }
            catch (System.Runtime.InteropServices.COMException ex) //catch any errors
            {
                textBox1.AppendText(ex.Message + Environment.NewLine); //append any errors to the textbox text
            }
        }

        void g_onRecord(object record)
        {
            //print the time from the data record
            textBox1.AppendText("DR-> " + g.sourceValue(record, "TIME").ToString() + Environment.NewLine);
        }

        void g_onMessage(string message)
        {
            textBox2.AppendText("MG-> " + message); //print to textbox
        }

        void g_onInterrupt(int status)
        {
            switch (status)
            {
                case 240:
                    //print status byte to text box
                    textBox3.AppendText("IR-> Case 1 interrupt  " + Environment.NewLine);
                    break;
                case 241:
                    //print status byte to text box
                    textBox3.AppendText("IR-> Case 2 interrupt  " + Environment.NewLine);
                    break;
                case 242:
                    //print status byte to text box
                    textBox3.AppendText("IR-> Case 3 interrupt  " + Environment.NewLine);
                    break;
                default:
                    //print status byte to text box
                    textBox3.AppendText("IR-> Undefined case    " + status.ToString() + Environment.NewLine);
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            g.recordsStart(0); //stop sending records
            g.command("ST"); //stop execution of asynchronous message progam

            g.onRecord -= new Galil.Events_onRecordEventHandler(g_onRecord); //unbind record to event
            g.onMessage -= new Galil.Events_onMessageEventHandler(g_onMessage); //unbind message to event
            g.onInterrupt -= new Galil.Events_onInterruptEventHandler(g_onInterrupt); //unbind interrupt to event
        }
    }
}
