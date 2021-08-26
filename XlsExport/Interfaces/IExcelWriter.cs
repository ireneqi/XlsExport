using NPOI.HSSF.UserModel;

namespace XlsExport.Interfaces
{
    interface IExcelWriter
    {
        void WriteToFile(HSSFWorkbook sheets, string filePath);
        void WriteText(string text, int sheetIndex, int rowIndex, int cellIndex);
        void WriteLine();
    }
}
