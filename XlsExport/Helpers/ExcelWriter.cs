using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XlsExport.Interfaces;

namespace XlsExport.Helpers
{
    public class ExcelWriter : IExcelWriter
    {
        private HSSFWorkbook _sheets;

        public ExcelWriter(Stream stream)
        {
            _sheets = new HSSFWorkbook(stream);
        }

        public void WriteLine()
        {
            throw new NotImplementedException();
        }

        public void WriteText(string text, int sheetIndex, int rowIndex, int cellIndex)
        {
            var sheet = _sheets.GetSheetAt(sheetIndex);
            if (sheet == null)
                sheet = _sheets.CreateSheet("Sheet");
            var cell=sheet.GetRow(rowIndex).GetCell(cellIndex);
            cell.SetCellValue(text);
        }

        public void Save()
        {
            _sheets.Write();
        }

        public void WriteToFile(HSSFWorkbook sheets, string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
