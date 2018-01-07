/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

/* ================================================================
 * Author: Tony Qu 
 * Author's email: tonyqus (at) gmail.com 
 * NPOI HomePage: http://www.codeplex.com/npoi
 * Contributors:
 * 
 * ==============================================================*/

using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using WEB测试.DTO;
using 测试web.Models;
using System.Collections.Generic;
using NPOI.SS.Util;
using NPOI.HSSF.Util;

namespace ExportXlsToDownload
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 普通导出npoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = "test.xls";
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", filename));
            Response.Clear();
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            Sheet sheet1 = hssfworkbook.CreateSheet("Sheet1");
            Sheet sheet2 = hssfworkbook.CreateSheet("Sheet2");

            sheet1.CreateRow(0).CreateCell(0).SetCellValue("This is a Sample");
            int x = 1;
            for (int i = 1; i <= 15; i++)
            {
                Row row = sheet1.CreateRow(i);
                for (int j = 0; j < 15; j++)
                {
                    row.CreateCell(j).SetCellValue(x++);
                }
            }
            MemoryStream file = new MemoryStream();
            hssfworkbook.Write(file);
            Response.BinaryWrite(file.GetBuffer());
            Response.End();
        }
        /// <summary>
        /// 普通单表导出npoi（集合数据+样式）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            string filename = "test.xls";
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", filename));
            Response.Clear();
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            Sheet sheet1 = hssfworkbook.CreateSheet("Sheet1名称");
            CellStyle styleCenter = hssfworkbook.CreateCellStyle();
            styleCenter.Alignment = HorizontalAlignment.CENTER;
            styleCenter.FillBackgroundColor = HSSFColor.PINK.index;

            var row0 = sheet1.CreateRow(0).CreateCell(0);
            row0.SetCellValue("This is a Sample");//sheet标题
            row0.CellStyle = styleCenter;

            #region 设置背景色
            CellStyle style1 = hssfworkbook.CreateCellStyle();
            style1.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.BLUE.index;
            style1.FillPattern = FillPatternType.SOLID_FOREGROUND;
            sheet1.CreateRow(18).CreateCell(18).CellStyle = style1;
            #endregion

            #region 自定义背景色
            HSSFPalette palette = hssfworkbook.GetCustomPalette(); //调色板实例
            palette.SetColorAtIndex((short)8, (byte)184, (byte)204, (byte)228);
            HSSFColor hssFColor = palette.FindColor((byte)184, (byte)204, (byte)228);
            CellStyle style2 = hssfworkbook.CreateCellStyle();
            style2.FillPattern = FillPatternType.SOLID_FOREGROUND;
            style2.FillForegroundColor = hssFColor.GetIndex();
            sheet1.CreateRow(19).CreateCell(19).CellStyle = style2;
            #endregion

            #region 设置字体颜色
            CellStyle style3 = hssfworkbook.CreateCellStyle();
            Font font1 = hssfworkbook.CreateFont();
            font1.Color = hssFColor.GetIndex();//颜色 
            style3.SetFont(font1);
            var cell20 = sheet1.CreateRow(20).CreateCell(20);
            cell20.CellStyle = style3;
            cell20.SetCellValue("666666666");
            #endregion

            List<ModelStu> data = StuDaTa.GetData();
            string[] arrthead = { "ID", "name", "age", "pc" };
            sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 0, arrthead.Length-1));
            Row row1 = sheet1.CreateRow(1);
            for (int i = 0; i < arrthead.Length; i++)
            {
                row1.CreateCell(i).SetCellValue(arrthead[i]);
            }
            for (int i = 0; i < data.Count; i++)
            {
                Row row = sheet1.CreateRow(i+2);
                var colIndex = 0;
                row.CreateCell(colIndex++).SetCellValue(data[i].id);
                row.CreateCell(colIndex++).SetCellValue(data[i].name);
                row.CreateCell(colIndex++).SetCellValue(data[i].age);
                row.CreateCell(colIndex).SetCellValue(data[i].pc);
            }
            MemoryStream file = new MemoryStream();
            hssfworkbook.Write(file);
            Response.BinaryWrite(file.GetBuffer());
            Response.End();
            hssfworkbook = null;
            file.Close();
            file.Dispose();
        }
    }
}
