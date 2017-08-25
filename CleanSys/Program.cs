using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanSys
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
     static class myData
    {
        public static Size myPossition;
        public static Form mainFrm;
        public static void ShowNewForm(Form presentFrm, Form newFrm)
        {
            myData.myPossition = (Size)presentFrm.Location;
            presentFrm.Close();
            newFrm.StartPosition = FormStartPosition.Manual;
            newFrm.Location = (Point)myData.myPossition;
            newFrm.Show();
        }
    }
}
