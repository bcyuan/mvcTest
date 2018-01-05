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
        /// 普通导出npoi
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
            Sheet sheet1 = hssfworkbook.CreateSheet("Sheet1");
            Sheet sheet2 = hssfworkbook.CreateSheet("Sheet2");

            sheet1.CreateRow(0).CreateCell(0).SetCellValue("This is a Sample");

            List<ModelStu> data = StuDaTa.GetData();


            MemoryStream file = new MemoryStream();
            hssfworkbook.Write(file);
            Response.BinaryWrite(file.GetBuffer());
            Response.End();
        }
    }
}
