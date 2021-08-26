using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using XlsExport.Interfaces;

namespace XlsExport.Helpers
{
    #region InterfaceForFont
    /// <summary>
    /// IFontStyleService
    /// </summary>
    public interface IFontStyleService
    {
        void RichFontSize(string str, int start, int end1, int end2);

         ICellStyle CommFontStyle(double point, string fontFamily, HorizontalAlignment ha = HorizontalAlignment.Center, VerticalAlignment va = VerticalAlignment.Center);
    }



    #endregion
    #region FontStyle Service

    public class FontStyleHelpers : IFontStyleService
    {
        protected static HSSFWorkbook _sheets;
        public FontStyleHelpers(HSSFWorkbook _hssfWorkbook)
        {
            _hssfWorkbook = _sheets;
        }
        /// <summary>
        /// apply font to 时刻列 时分为9号，秒为6.5号
        /// </summary>
        /// <param name="str"></param>
        /// <param name="start"></param>
        /// <param name="end1"></param>
        /// <param name="end2"></param>
        public void RichFontSize(string str, int start, int end1, int end2)
        {
            HSSFRichTextString richtext = new HSSFRichTextString(str);
            //apply font to 时刻列 时分为9号
            IFont font1 = _sheets.CreateFont();
            font1.FontName = "宋体";
            font1.FontHeightInPoints = 9;
            richtext.ApplyFont(start, end1, font1);


            //apply font to 时刻列 时分为6.5号
            IFont font2 = _sheets.CreateFont();
            font2.FontName = "宋体";
            font2.FontHeightInPoints = 6.5;
            richtext.ApplyFont(end1, end2, font2);

        }
        /// <summary>
        /// CommFontStyle常用字体样式
        /// </summary>
        /// <param name="str"></param>
        ///  调用方法
        // ICell cell1 = CellUtil.CreateCell(sheet1.CreateRow(1), 1, "Hello World!");
        //cell1.CellStyle = style1;
        public ICellStyle CommFontStyle(double point, string fontFamily,HorizontalAlignment ha=HorizontalAlignment.Center,VerticalAlignment va=VerticalAlignment.Center)
        {

            //font style1: underlined, italic, red color, fontsize=20
            IFont font1 = _sheets.CreateFont();
            font1.FontHeightInPoints = point;
            font1.FontName = fontFamily;
            font1.FontHeightInPoints = 20;

            //bind font with style 1
            ICellStyle style1 = _sheets.CreateCellStyle();
            style1.Alignment = ha;
            style1.VerticalAlignment = va;
            style1.SetFont(font1);
            return style1;
        }
    }
    #endregion

}
