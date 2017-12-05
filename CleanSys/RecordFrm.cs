using CCWin;
using CCWin.SkinControl;
using CleanSys.Properties;
using CleanSys.Util;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CleanSys
{
    public partial class RecordFrm : CCSkinMain
    {
        
        public RecordFrm()
        {
            InitializeComponent();
        }

        private void RecordFrm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("backgroud2")));

            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
            
            RecordData.checkButton[0, 0] = b11;
            RecordData.checkButton[0, 1] = b12;
            RecordData.checkButton[0, 2] = b13;
            RecordData.checkButton[0, 3] = b14;
            RecordData.checkButton[0, 4] = b15;
            RecordData.checkButton[0, 5] = b16;
            RecordData.checkButton[0, 6] = b17;
            RecordData.checkButton[0, 7] = b18;
            RecordData.checkButton[1, 0] = b21;
            RecordData.checkButton[1, 1] = b22;
            RecordData.checkButton[1, 2] = b23;
            RecordData.checkButton[1, 3] = b24;
            RecordData.checkButton[1, 4] = b25;
            RecordData.checkButton[1, 5] = b26;
            RecordData.checkButton[1, 6] = b27;
            RecordData.checkButton[1, 7] = b28;
            RecordData.checkButton[2, 0] = b31;
            RecordData.checkButton[2, 1] = b32;
            RecordData.checkButton[2, 2] = b33;
            RecordData.checkButton[2, 3] = b34;
            RecordData.checkButton[2, 4] = b35;
            RecordData.checkButton[2, 5] = b36;
            RecordData.checkButton[2, 6] = b37;
            RecordData.checkButton[2, 7] = b38;
            RecordData.checkButton[3, 0] = b41;
            RecordData.checkButton[3, 1] = b42;
            RecordData.checkButton[3, 2] = b43;
            RecordData.checkButton[3, 3] = b44;
            RecordData.checkButton[3, 4] = b45;
            RecordData.checkButton[3, 5] = b46;
            RecordData.checkButton[3, 6] = b47;
            RecordData.checkButton[3, 7] = b48;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    RecordData.checkButton[i, j].BackColor = RecordData.UncheckColor;
                }
            }


        }

        private void b11_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b11;

            //NumberkeyBoard keyboard = new NumberkeyBoard
            //{
            //    MdiParent = this
            //};
            //keyboard.TopMost = true;
            //keyboard.Show();
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b12;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();

        }

        private void b13_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b13;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b14;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();
        }

        private void b15_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b15;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();
        }

        private void b16_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b16;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();
        }

        private void b17_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b17;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();
        }

        private void b18_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b18;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            myData.mainFrm.Visible = true;
            this.Close();
        }

        private void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }

        private void Record_Click(object sender, EventArgs e)
        {
            string RecordData = string.Empty;
            // get  Header info
            RecordData += comboBox1.Text;
            RecordData += "/t" + comboBox2.Text;
            RecordData += "/t" + comboBox3.Text;
            RecordData += "/t" + dateTimePicker1.Text;
            // get  Check info
           // RecordData += RecordData.GetButtonSt();

        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            myData.mainFrm.Visible = true;
            this.Close();
        }

        private void RecordBut_Click(object sender, EventArgs e)
        {
            string RecordData = string.Empty;
            // get  Header info
            // get  Check info
            // RecordData += RecordData.GetButtonSt();
            // myData.SaveRecord(RecordData);
            string fileName = string.Format("record_{0}.xls", DateTime.Now.ToString("yyyyMMdd"));
            string filePath = System.IO.Directory.GetCurrentDirectory() + fileName;
            WriteToExcel(filePath);
        }



        private void b21_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b21;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();
        }

        private void b22_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b22;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();
        }

        private void b23_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b23;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();
        }

        private void b24_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b24;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();
        }

        private void b25_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b25;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();
        }

        private void b26_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b26;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();
        }

        private void b27_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b27;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();

        }

        private void b28_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b28;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();

        }

        private void b31_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b31;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();

        }

        private void b32_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b32;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();
        }

        private void b33_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b33;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();

        }

        private void b34_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b34;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();
        }

        private void b35_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b35;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();

        }



        private void b36_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b36;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();

        }

        private void b37_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b37;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();
        }

        private void b38_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b38;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();
        }

        private void b41_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b41;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();
        }

        private void b42_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b42;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();

        }

        private void b43_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b43;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();

        }

        private void b44_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b44;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();
        }

        private void b45_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b45;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b12.Location);
            keyboard.ShowDialog();
        }

        private void b46_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b46;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b13.Location);
            keyboard.ShowDialog();
        }

        private void b47_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b47;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b14.Location);
            keyboard.ShowDialog();
        }

        private void b48_Click(object sender, EventArgs e)
        {
            RecordData.EditButton = b48;
            NumberkeyBoard keyboard = new NumberkeyBoard();
            keyboard.Location = setPoint(b15.Location);
            keyboard.ShowDialog();
        }

        private  Point setPoint(Point poi)
        {
            Point ret = new Point();
            ret.X = poi.X + skinGroupBox1.Location.X;
            ret.Y = poi.Y + skinGroupBox1.Location.Y;
            return ret;

        }
        private void WriteToExcel(string filePath)
        {
            //创建工作薄  
            IWorkbook wb;
            //string extension = System.IO.Path.GetExtension(filePath);
            //根据指定的文件格式创建对应的类
            //if (extension.Equals(".xls"))
            //{
            //    wb = new HSSFWorkbook();
            //}
            //else
            //{
            //    wb = new XSSFWorkbook();
            //}
            wb = new HSSFWorkbook();
            ICellStyle style1 = wb.CreateCellStyle();//样式
            style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT;//文字水平对齐方式
            style1.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER;//文字垂直对齐方式
                         
            //设置边框
            
            style1.BorderBottom = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style1.BorderLeft = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style1.BorderRight = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style1.BorderTop = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style1.WrapText = true;//自动换行

            ICellStyle style2 = wb.CreateCellStyle();//样式
            IFont font1 = wb.CreateFont();//字体
            font1.FontName = "楷体";
            font1.Color = HSSFColor.BLACK.index;//字体颜色
            font1.Boldweight = (short)FontBoldWeight.NORMAL;//字体加粗样式
            style2.SetFont(font1);//样式里的字体设置具体的字体样式
                                  
            //设置背景色
            style2.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.YELLOW.index;
            //style2.FillPattern = FillPattern.SolidForeground;
            style2.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.YELLOW.index;
            style2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER;//文字水平对齐方式
            style2.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER;//文字垂直对齐方式
            style2.BorderBottom = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style2.BorderLeft = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style2.BorderRight = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style2.BorderTop = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
            style2.WrapText = true;//自动换行

            ICellStyle dateStyle = wb.CreateCellStyle();//样式
            dateStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT;//文字水平对齐方式
            dateStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER;//文字垂直对齐方式
                                                                                     //设置数据显示格式
            IDataFormat dataFormatCustom = wb.CreateDataFormat();
            dateStyle.DataFormat = dataFormatCustom.GetFormat("yyyy-MM-dd HH:mm:ss");

            //创建一个表单
            ISheet sheet = wb.CreateSheet("Sheet0");
            //设置列宽
            int[] columnWidth = { 10, 10, 10, 10,10,10,10,10,10,10 };
            for (int i = 0; i < columnWidth.Length; i++)
            {
                //设置列宽度，256*字符数，因为单位是1/256个字符
                sheet.SetColumnWidth(i, 256 * columnWidth[i]);
            }

            //测试数据
            int rowCount = 5, columnCount = 9;
   
        //日期可以直接传字符串，NPOI会自动识别
        //如果是DateTime类型，则要设置CellStyle.DataFormat，否则会显示为数字
   

            IRow row;
            ICell cell;
            
            row = sheet.CreateRow(0);//创建第0行
            cell = row.CreateCell(0);//创建第j列
            cell.SetCellValue("轨道编号");
            cell.CellStyle = style1;
            cell = row.CreateCell(1);//创建第j列
            cell.SetCellValue("检测点1");
            cell.CellStyle = style1;
            cell = row.CreateCell(2);//创建第j列
            cell.SetCellValue("检测点2");
            cell.CellStyle = style1;
            cell = row.CreateCell(3);//创建第j列
            cell.SetCellValue("检测点3");
            cell.CellStyle = style1;
            cell = row.CreateCell(4);//创建第j列
            cell.SetCellValue("检测点4");
            cell.CellStyle = style1;
            cell = row.CreateCell(5);//创建第j列
            cell.SetCellValue("检测点5");
            cell.CellStyle = style1;
            cell = row.CreateCell(6);//创建第j列
            cell.SetCellValue("检测点6");
            cell = row.CreateCell(7);//创建第j列
            cell.SetCellValue("检测点7");
            cell.CellStyle = style1;
            cell = row.CreateCell(8);//创建第j列
            cell.SetCellValue("检测点8");
            cell.CellStyle = style1;

            for (int i = 1; i < rowCount; i++)
            {
                row = sheet.CreateRow(i);//创建第i行
                cell = row.CreateCell(0);//创建第0列
                cell.SetCellValue(i);
                cell.CellStyle = style2;
                for (int j = 1; j < columnCount; j++)
                {
                    cell = row.CreateCell(j);//创建第j列
                    cell.SetCellValue(RecordData.checkButton[i-1,j-1].Text);
                    cell.CellStyle = style1;
                    //cell.CellStyle = j % 2 == 0 ? style1 : style2;

                    ////根据数据类型设置不同类型的cell
                    //object obj = data[i, j];

                    //cell.SetCellValue("1");
                    ////如果是日期，则设置日期显示的格式
                    //if (obj.GetType() == typeof(DateTime))
                    //{
                    //    cell.CellStyle = dateStyle;
                    //}
                    //如果要根据内容自动调整列宽，需要先setCellValue再调用
                    //sheet.AutoSizeColumn(j);
                }
            }

            row = sheet.CreateRow(8);//创建第8行
            cell = row.CreateCell(0);//创建第0列
            cell.SetCellValue("箱编号");
            cell.CellStyle = style1;

            cell = row.CreateCell(1);//创建第1列
            cell.CellStyle = style1;

            cell = row.CreateCell(2);//创建第2列
            cell.SetCellValue("操作员");
            cell.CellStyle = style1;

            cell = row.CreateCell(3);//创建第3列
            cell.CellStyle = style1;

            cell = row.CreateCell(4);//创建第4列
            cell.SetCellValue("箱壁清理状态");
            cell.CellStyle = style1;

            cell = row.CreateCell(5);//创建第5列
            cell.CellStyle = style1;


            cell = row.CreateCell(6);//创建第6列
            cell.SetCellValue("箱壁清理时间");
            cell.CellStyle = style1;
            cell = row.CreateCell(7);//创建第7列
            cell.CellStyle = style1;

            row = sheet.CreateRow(9);//创建第9行
            cell = row.CreateCell(0);//创建第0列
            cell.SetCellValue(comboBox1.Text);
            cell.CellStyle = style1;

            cell = row.CreateCell(1);//创建第1列
            cell.CellStyle = style1;

            cell = row.CreateCell(2);//创建第2列
            cell.SetCellValue(comboBox2.Text);
            cell.CellStyle = style1;

            cell = row.CreateCell(3);//创建第3列
            cell.CellStyle = style1;

            cell = row.CreateCell(4);//创建第4列
            cell.SetCellValue(comboBox3.Text);
            cell.CellStyle = style1;

            cell = row.CreateCell(5);//创建第5列
            cell.CellStyle = style1;


            cell = row.CreateCell(6);//创建第6列
            cell.SetCellValue(dateTimePicker1.Text);
            cell.CellStyle = style1;

            cell = row.CreateCell(7);//创建第7列
            cell.CellStyle = style1;

            //CellRangeAddress(0, 2, 0, 0)，合并0 - 2行，0 - 0列的单元格
            for (int x = 8; x < 10; x++)
            {
                for (int y = 0; y < 8; y = y + 2)
                {
                    CellRangeAddress region = new CellRangeAddress(x, x, y, y + 1);
                    sheet.AddMergedRegion(region);
                    
                }
            }


            //合并单元格，如果要合并的单元格中都有数据，只会保留左上角的
            //CellRangeAddress(0, 2, 0, 0)，合并0-2行，0-0列的单元格
            //CellRangeAddress region = new CellRangeAddress(0, 2, 0, 0);
            //sheet.AddMergedRegion(region);

            using (FileStream fs = File.OpenWrite(filePath)) //打开一个xls文件，如果没有则自行创建，如果存在myxls.xls文件则在创建是不要打开该文件！
            {
                wb.Write(fs);   //向打开的这个xls文件中写入mySheet表并保存。
                fs.Close();
                MessageBox.Show("提示：创建成功！");
            }
            //try
            //{
            //    FileStream fs = File.OpenWrite(filePath);
            //    wb.Write(fs);//向打开的这个Excel文件中写入表单并保存。  
            //    fs.Close();
            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine(e.Message);
            //}
        }
    }
    public static class RecordData
    {
        public static Color Checkcolor = Color.Green;
        public static Color UncheckColor = Color.Black;
        public static SkinButton[,] checkButton = new SkinButton[4, 8];
        public static SkinButton EditButton = new SkinButton();
        public static string GetButtonSt()
        {
            string st = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                st = st + "/t"+ "N" + System.Convert.ToString(i+1) +"-";
                for (int j = 0; j < 8; j++)
                {
                    st += checkButton[i, j].Text;
                    st += "-";
                    
                }
            }
            return st;
        }

    }

}
