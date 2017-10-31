using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static CCWin.Win32.NativeMethods;

namespace CleanSys.Util
{
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

        public static Stack<Form> frmStack = new Stack<Form>();

        public static string MiddleTitle()
        {
            return DateTime.Now.ToString("M月dd日") + "  " + GetWeek();
        }

        public static string RightTime()
        {
            return DateTime.Now.ToString("hh:mm");
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

        #region dead Code
        public static void SaveRecord(string content)
        {
            string fileName = string.Format("record_{0}.log", DateTime.Now.ToString("yyyyMMdd"));
            string filePath = @".\log\" + fileName;
            string title = "箱编号\t操作员\t清理状态\t清理时间\t轨道1\t轨道2\t轨道3\t轨道4\n";

            if (!File.Exists(filePath))
            {
                File.AppendAllText(filePath, title);
            }

            File.AppendAllText(filePath, content);
        }
        #endregion

    }
}
