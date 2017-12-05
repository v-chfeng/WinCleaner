CONNECTING TO A GALIL CONTROLLER FROM MICROSOFT VISUAL C#.NET 2012 USING GALILTOOLS COMMUNICATION LIBRARY

(1) Install GalilTools version 1.3.0.0 or newer on Windows XP or newer.  Lite is free of charge, the full version required a purchased password.  Either is fine for this walkthrough.
http://www.galilmc.com/support/software-downloads.php

(2) Connect to the controller using GalilTools
http://www.galilmc.com/support/manuals/galiltools/connections.html#available

(3) Open Microsoft Visual Studio 2012 Express, select File | New Project | Windows Forms Application and type "Hello_Galil" for the name. Ensure that the project template is Visual C# in the tree menu on the left.  Click OK. 

(4) Add a Label to the form by clicking "Label" under "All Windows Forms" in the Toolbox. 

(5) In the Solution Explorer window, right click "Hello_Galil" and choose "Add Reference".  The Reference dialog may take a few moments to populate.

(6) Click the COM in the tree menu on the left.  Find "Galil" in the list.  Select the checkbox next to it then click OK.

(7) Double click on the title bar of the form to enter the code section.

(8) Modify the code inside of the public partial class Form1 : From section to make it look like the following:

    public partial class Form1 : Form
    {
        static Galil.Galil g;

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
    
(9)  Push F5 to compile and run the application.  The program will display the connections dialog, identical to GalilTools.  Choose the same controller you connected to in step (2).  The output should be similar to:

  GalilClass1.dll 1.5.0.0
  Galil1.dll 1.6.0.460
  192.168.1.155, RIO47100 Rev 1.0c1, 1155, IHA IHB
  MG TIME 4799941

Also See:
http://www.galilmc.com/support/manuals/galiltools/library.html



