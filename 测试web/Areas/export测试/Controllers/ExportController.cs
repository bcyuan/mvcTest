using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using 测试web.Models;

namespace 测试web.Areas.export测试.Controllers
{
    public class ExportController : Controller
    {
        // GET: export测试/Home
        public ActionResult Index()
        {
            return View();
        }


        #region window.location.href导出
        public void ToExcel(string keyword)
        {

            List<stu> awardListDorm =new List<stu> {
               new stu{num=1,name="zs",age=18},
               new stu{num=1,name="zs",age=18},
               new stu{num=1,name="zs",age=18},
               new stu{num=1,name="zs",age=18}
            };
            string SheetName = "请假学生表";
            string[] arr = "学号,姓名,专业".Split(',');
            string ExcelName = SheetName + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            //XlsDocument对象
            var doc = new AppLibrary.WriteExcel.XlsDocument();
            #region 解决文件名火狐导出乱码问题
            doc.FileName = Request.ServerVariables["http_user_agent"].ToLower().IndexOf("firefox", StringComparison.Ordinal) != -1 ? string.Format("\"{0}\"", ExcelName) : System.Web.HttpUtility.UrlPathEncode(ExcelName);
            #endregion
            int rowIndex = 3;
            int i = 1;
            var sheet1 = doc.Workbook.Worksheets.Add(ExcelName);
            var cells = sheet1.Cells;
            sheet1.Cells.Merge(1, 1, 1, arr.Length + 1);
            cells.Add(1, 1, SheetName).HorizontalAlignment = AppLibrary.WriteExcel.HorizontalAlignments.Centered;
            for (int j = 0; j < arr.Length; j++)
            {
                cells.Add(2, j + 1, arr[j].ToString());
            }
            foreach (var item in awardListDorm)
            {
                var colIndex = 1;
                cells.Add(rowIndex, colIndex, i);
                cells.Add(rowIndex, colIndex ++, item.num);
                cells.Add(rowIndex, colIndex ++, item.name);
                cells.Add(rowIndex, colIndex ++, item.age);
                rowIndex++;
                i++;
            }
            doc.Send();
            Response.Flush();
            Response.End();
            //return File("", "application/ms-excel");
        }
        #endregion


        #region ajax导出
        public FileResult ToExcel2(string keyword)
        {

            List<stu> awardListDorm = new List<stu> {
               new stu{num=1,name="zs",age=18},
               new stu{num=1,name="zs",age=18},
               new stu{num=1,name="zs",age=18},
               new stu{num=1,name="zs",age=18}
            };
            string SheetName = "请假学生表";
            string[] arr = "学号,姓名,专业".Split(',');
            string ExcelName = SheetName + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            //XlsDocument对象
            var doc = new AppLibrary.WriteExcel.XlsDocument();
            #region 解决文件名火狐导出乱码问题
            doc.FileName = Request.ServerVariables["http_user_agent"].ToLower().IndexOf("firefox", StringComparison.Ordinal) != -1 ? string.Format("\"{0}\"", ExcelName) : System.Web.HttpUtility.UrlPathEncode(ExcelName);
            #endregion
            int rowIndex = 3;
            int i = 1;
            var sheet1 = doc.Workbook.Worksheets.Add(ExcelName);
            var cells = sheet1.Cells;
            sheet1.Cells.Merge(1, 1, 1, arr.Length + 1);
            cells.Add(1, 1, SheetName).HorizontalAlignment = AppLibrary.WriteExcel.HorizontalAlignments.Centered;
            for (int j = 0; j < arr.Length; j++)
            {
                cells.Add(2, j + 1, arr[j].ToString());
            }
            foreach (var item in awardListDorm)
            {
                var colIndex = 1;
                cells.Add(rowIndex, colIndex, i);
                cells.Add(rowIndex, colIndex++, item.num);
                cells.Add(rowIndex, colIndex++, item.name);
                cells.Add(rowIndex, colIndex++, item.age);
                rowIndex++;
                i++;
            }
            doc.Send();
            Response.Flush();
            Response.End();
            return File("555555", "application/ms-excel");
        }
        #endregion


        public FileResult ToExcel3()
        {
            var sbHtml = new StringBuilder();
            sbHtml.Append("<table border='1' cellspacing='0' cellpadding='0'>");
            sbHtml.Append("<tr>");
            var lstTitle = new List<string> { "编号", "姓名", "年龄", "创建时间" };
            foreach (var item in lstTitle)
            {
                sbHtml.AppendFormat("<td style='font-size: 14px;text-align:center;background-color: #DCE0E2; font-weight:bold;' height='25'>{0}</td>", item);
            }
            sbHtml.Append("</tr>");

            for (int i = 0; i < 10; i++)
            {
                sbHtml.Append("<tr>");
                sbHtml.AppendFormat("<td style='font-size: 12px;height:20px;'>{0}</td>", i);
                sbHtml.AppendFormat("<td style='font-size: 12px;height:20px;'>屌丝{0}号</td>", i);
                sbHtml.AppendFormat("<td style='font-size: 12px;height:20px;'>{0}</td>", new Random().Next(20, 30) + i);
                sbHtml.AppendFormat("<td style='font-size: 12px;height:20px;'>{0}</td>", DateTime.Now);
                sbHtml.Append("</tr>");
            }
            sbHtml.Append("</table>");

            //第一种:使用FileContentResult  
            byte[] fileContents = Encoding.Default.GetBytes(sbHtml.ToString());
            return File(fileContents, "application/ms-excel", "fileContents.xls");

            //第二种:使用FileStreamResult  
            var fileStream = new MemoryStream(fileContents);
            return File(fileStream, "application/ms-excel", "fileStream.xls");

            //第三种:使用FilePathResult  
            //服务器上首先必须要有这个Excel文件,然会通过Server.MapPath获取路径返回.  
            var fileName = Server.MapPath("~/Files/fileName.xls");
            return File(fileName, "application/ms-excel", "fileName.xls");
        }
    }
}