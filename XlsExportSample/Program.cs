using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XlsExport.Helpers;

namespace XlsExportSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"test.xls";

            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                var excelWriter= new ExcelWriter(fs);
                excelWriter.WriteText("Hello", 0, 0, 0);
            }
        }
    }
}
