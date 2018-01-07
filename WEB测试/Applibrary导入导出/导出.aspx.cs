using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB测试.DTO;
using 测试web.Models;

namespace WEB测试.Applibrary导入导出
{
    public partial class 导出 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region 分组多表导出
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            List<ModelStu> list = StuDaTa.GetData();//集合数据

            string SheetName = "请假学生表";
            string[] arr = "编号,年龄,姓名,PC".Split(',');
            string DocName = SheetName + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            #region XlsDocument对象
            var doc = new AppLibrary.WriteExcel.XlsDocument();
            #region 解决文件名火狐导出乱码问题
            doc.FileName = Request.ServerVariables["http_user_agent"].ToLower().IndexOf("firefox", StringComparison.Ordinal) != -1 ? string.Format("\"{0}\"", DocName) : System.Web.HttpUtility.UrlPathEncode(DocName);
            #endregion
            #endregion
            var glist = list.GroupBy(s => s.age);

            foreach (var gitem in glist)
            {
                SheetName = "KEY值：" + gitem.Key;
                AppLibrary.WriteExcel.Worksheet sheet = doc.Workbook.Worksheets.Add(SheetName);
                AppLibrary.WriteExcel.Cells cells = sheet.Cells;
                sheet.Cells.Merge(1, 1, 1, arr.Length);
                cells.Add(1, 1, SheetName).HorizontalAlignment = AppLibrary.WriteExcel.HorizontalAlignments.Centered;
                for (int m = 0; m < arr.Length; m++)
                {
                    cells.Add(2, m + 1, arr[m].ToString());
                }
                List<ModelStu> tmplst = new List<ModelStu>();
                foreach (var item in gitem) { tmplst.Add(item); }
                int rowIndex = 3;
                foreach (var itemSheet in tmplst)//sheet块
                {
                    var colIndex = 1;
                    cells.Add(rowIndex, colIndex++, itemSheet.id);
                    cells.Add(rowIndex, colIndex++, itemSheet.age);
                    cells.Add(rowIndex, colIndex++, itemSheet.name);
                    cells.Add(rowIndex, colIndex++, itemSheet.pc);
                    rowIndex++;
                }
            }
            doc.Send();
            Response.Flush();
            Response.End();
            //return File(DocName, "application/ms-excel");
        }
        #endregion

        #region 分组表，分组行导出
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            List<ModelStu> list = StuDaTa.GetData();//集合数据

            string SheetName = "请假学生表";
            string[] arr = "编号,年龄,姓名,PC".Split(',');
            string DocName = SheetName + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            #region XlsDocument对象
            var doc = new AppLibrary.WriteExcel.XlsDocument();
            #region 解决文件名火狐导出乱码问题
            doc.FileName = Request.ServerVariables["http_user_agent"].ToLower().IndexOf("firefox", StringComparison.Ordinal) != -1 ? string.Format("\"{0}\"", DocName) : System.Web.HttpUtility.UrlPathEncode(DocName);
            #endregion
            #endregion
            var g1 = list.GroupBy(s => s.age);
            foreach (var item1 in g1)
            {
                SheetName = "KEY值：" + item1.Key;
                AppLibrary.WriteExcel.Worksheet sheet = doc.Workbook.Worksheets.Add(SheetName);
                AppLibrary.WriteExcel.Cells cells = sheet.Cells;
                cells.Add(1, 1, SheetName).HorizontalAlignment = AppLibrary.WriteExcel.HorizontalAlignments.Centered;
                sheet.Cells.Merge(1, 1, 1, arr.Length);
                for (int m = 0; m < arr.Length; m++)
                {
                    cells.Add(2, m + 1, arr[m].ToString());
                }
                List<ModelStu> list2 = new List<ModelStu>();
                foreach (var itemtmp in item1) { list2.Add(itemtmp); }//新集合
                var g2 = list2.GroupBy(s => s.name);
                var rowIndex = 1;//applibrary的row和col索引从1开始
                foreach (var item2 in g2)
                {
                    List<ModelStu> list3 = new List<ModelStu>();
                    foreach (var itemtmp in item2) { list3.Add(itemtmp); }//新集合
                    cells.Add(rowIndex++, 1, item2.Key).HorizontalAlignment = AppLibrary.WriteExcel.HorizontalAlignments.Centered;
                    foreach (var item3 in list3)
                    {
                        var colIndex = 1;
                        cells.Add(rowIndex, colIndex++, item3.id);
                        cells.Add(rowIndex, colIndex++, item3.age);
                        cells.Add(rowIndex, colIndex++, item3.name);
                        cells.Add(rowIndex, colIndex++, item3.pc);
                        rowIndex++;
                    }
                    sheet.Cells.Merge(rowIndex, rowIndex, 1, arr.Length);
                }
            }
            doc.Send();
            Response.Flush();
            Response.End();
            //return File(DocName, "application/ms-excel");
        }
        #endregion
    }
}