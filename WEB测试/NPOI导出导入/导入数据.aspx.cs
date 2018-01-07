using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB测试.NPOI导出
{
    public partial class 导入数据 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 读取xls文件，到dataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            HSSFWorkbook hssfworkbook;
            using (FileStream file = new FileStream(Server.MapPath(@"试题上传.xls"), FileMode.Open, FileAccess.Read))
            {
                hssfworkbook = new HSSFWorkbook(file);
            }
            Sheet sheet = hssfworkbook.GetSheetAt(0);
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();
            DataTable dt = new DataTable();
            for (int j = 0; j < 6; j++)
            {
                dt.Columns.Add(Convert.ToChar(((int)'A') + j).ToString());
            }
            while (rows.MoveNext())
            {
                Row row = (HSSFRow)rows.Current;
                DataRow dr = dt.NewRow();
                for (int i = 0; i < row.LastCellNum; i++)//LastCellNum读取最后一行的索引
                {
                    Cell cell = row.GetCell(i);
                    if (cell == null)
                    {
                        dr[i] = null;
                    }
                    else
                    {
                        dr[i] = cell.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
        }
    }
}