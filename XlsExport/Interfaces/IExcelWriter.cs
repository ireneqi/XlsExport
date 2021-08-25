namespace XlsExport.Interfaces
{
    interface IExcelWriter
    {
        void WriteText(string text,int rowIndex,int colIndex);
        void WriteLine();
    }
}
