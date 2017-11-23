CONNECTING TO A GALIL CONTROLLER FROM MICROSOFT VISUAL C#.NET 2012 USING GALILTOOLS COMMUNICATION LIBRARY

(1) Install GalilTools version 1.3.0.0 or newer on Windows XP or newer.  Lite is free of charge, the full version required a purchased password.  Either is fine for this walkthrough.
http://www.galilmc.com/support/software-downloads.php

(2) Connect to the controller using GalilTools
http://www.galilmc.com/support/manuals/galiltools/connections.html#available

(3) Open Microsoft Visual Studio 2012 Express, select File | New Project | Windows Forms Application and type "Event_Driven" for the name. Ensure that the project template is Visual C# in the tree menu on the left.  Click OK. 

(4) Add a textbox to the form by clicking "TextBox" under "All Windows Forms" in the Toolbox. 

(5) Copy then paste the Textbox two times to create 3 instances total.

(6) In the Solution Explorer window, right click "Event_Driven" and choose "Add Reference".  The Reference dialog may take a few moments to populate.

(7) Click the COM in the tree menu on the left.  Find "Galil" in the list.  Select the checkbox next to it then click OK.

(8) Double click on the title bar of the form to enter the code section.

(9) Return to the design tab and single click on the form title bar. In the properties window click on the lightning bold that represents events. Find the FormClosed event in the table below and double click the empty field next to it.  

(10) Modify the code inside of the private partial class From1 : Form section to make it look like the following:
   
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
        
        void g_onInterrupt(int status){
            switch(status){
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
    
(11) Push F5 to compile and run the application. 

Also See:
http://www.galilmc.com/support/manuals/galiltools/library.html



