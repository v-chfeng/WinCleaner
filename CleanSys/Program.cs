using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public static string MiddleTitle()
        {
            return DateTime.Now.ToString("M月dd日") + "  " + GetWeek();
        }

        public static string RightTime()
        {
            return DateTime.Now.ToShortTimeString();
        }

         public static string GetWeek()
        {
            DayOfWeek week = DateTime.Now.DayOfWeek;
            string weekStr = string.Empty;
            switch (week)
            {
                case DayOfWeek.Monday:
                    weekStr = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    weekStr = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    weekStr = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    weekStr = "星期四";
                    break;
                case DayOfWeek.Friday:
                    weekStr = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    weekStr = "星期六";
                    break;
                case DayOfWeek.Sunday:
                    weekStr = "星期日";
                    break;
            }

            return weekStr;
        }

        public static void SaveRecord()
        {            
            string fileName = string.Format("record_{0}.log", DateTime.Now.ToString("yyyyMMdd"));
            string filePath = @".\log\" + fileName;
            string content = "";

            File.AppendAllText(filePath, content);
        }
    }
}
