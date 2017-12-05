using System.Collections;
using System.IO;
using NPOI.SS.UserModel;

namespace CleanSys
{
    internal class XSSFWorkbook : IWorkbook
    {
        public int ActiveSheetIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
        public int FirstVisibleTab { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

        public int NumberOfSheets { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

        public short NumberOfFonts { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

        public short NumCellStyles { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

        public int NumberOfNames { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

        public MissingCellPolicy MissingCellPolicy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
        public bool IsHidden { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

        public int AddPicture(byte[] pictureData, PictureType format)
        {
            throw new System.NotImplementedException();
        }

        public ISheet CloneSheet(int sheetNum)
        {
            throw new System.NotImplementedException();
        }

        public ICellStyle CreateCellStyle()
        {
            throw new System.NotImplementedException();
        }

        public IDataFormat CreateDataFormat()
        {
            throw new System.NotImplementedException();
        }

        public IFont CreateFont()
        {
            throw new System.NotImplementedException();
        }

        public IName CreateName()
        {
            throw new System.NotImplementedException();
        }

        public ISheet CreateSheet()
        {
            throw new System.NotImplementedException();
        }

        public ISheet CreateSheet(string sheetname)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IFont FindFont(short boldWeight, short color, short fontHeight, string name, bool italic, bool strikeout, short typeOffset, byte underline)
        {
            throw new System.NotImplementedException();
        }

        public IList GetAllPictures()
        {
            throw new System.NotImplementedException();
        }

        public ICellStyle GetCellStyleAt(short idx)
        {
            throw new System.NotImplementedException();
        }

        public CreationHelper GetCreationHelper()
        {
            throw new System.NotImplementedException();
        }

        public IFont GetFontAt(short idx)
        {
            throw new System.NotImplementedException();
        }

        public IName GetName(string name)
        {
            throw new System.NotImplementedException();
        }

        public IName GetNameAt(int nameIndex)
        {
            throw new System.NotImplementedException();
        }

        public int GetNameIndex(string name)
        {
            throw new System.NotImplementedException();
        }

        public string GetPrintArea(int sheetIndex)
        {
            throw new System.NotImplementedException();
        }

        public ISheet GetSheet(string name)
        {
            throw new System.NotImplementedException();
        }

        public ISheet GetSheetAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public int GetSheetIndex(string name)
        {
            throw new System.NotImplementedException();
        }

        public int GetSheetIndex(ISheet sheet)
        {
            throw new System.NotImplementedException();
        }

        public string GetSheetName(int sheet)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSheetHidden(int sheetIx)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSheetVeryHidden(int sheetIx)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveName(int index)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveName(string name)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePrintArea(int sheetIndex)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveSheetAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public void SetActiveSheet(int sheetIndex)
        {
            throw new System.NotImplementedException();
        }

        public void SetPrintArea(int sheetIndex, string reference)
        {
            throw new System.NotImplementedException();
        }

        public void SetPrintArea(int sheetIndex, int startColumn, int endColumn, int startRow, int endRow)
        {
            throw new System.NotImplementedException();
        }

        public void SetRepeatingRowsAndColumns(int sheetIndex, int startColumn, int endColumn, int startRow, int endRow)
        {
            throw new System.NotImplementedException();
        }

        public void SetSelectedTab(int index)
        {
            throw new System.NotImplementedException();
        }

        public void SetSheetHidden(int sheetIx, SheetState hidden)
        {
            throw new System.NotImplementedException();
        }

        public void SetSheetHidden(int sheetIx, int hidden)
        {
            throw new System.NotImplementedException();
        }

        public void SetSheetName(int sheet, string name)
        {
            throw new System.NotImplementedException();
        }

        public void SetSheetOrder(string sheetname, int pos)
        {
            throw new System.NotImplementedException();
        }

        public void Write(Stream stream)
        {
            throw new System.NotImplementedException();
        }
    }
}