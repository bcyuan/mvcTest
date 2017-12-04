using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 测试web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #region 导出

        public void ToExcel(string keyword)
        {
            
            //List<AwardListClassDTO> awardListClass = awardsBLL.GetGridJsonClass(queryDto, userInfo);

            string ExcelName = "6S评选-班级评选表_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            //XlsDocument对象
            var doc = new AppLibrary.WriteExcel.XlsDocument();
            //保存的文件名
            #region 解决火狐导出乱码问题
            doc.FileName = Request.ServerVariables["http_user_agent"].ToLower().IndexOf("firefox", StringComparison.Ordinal) != -1 ? string.Format("\"{0}\"", ExcelName) : System.Web.HttpUtility.UrlPathEncode(ExcelName);
            #endregion
            //工作簿
            //单元格
            int rowIndex = 3, colIndex = 1, i = 1;
            var sheet1 = doc.Workbook.Worksheets.Add(ExcelName);
            var cells = sheet1.Cells;
            sheet1.Cells.Merge(1, 1, 1, 6);
            cells.Add(1, 1, "6S评选-班级评选表").HorizontalAlignment = AppLibrary.WriteExcel.HorizontalAlignments.Centered;
            cells.Add(2, 1, "编号");
            cells.Add(2, 2, "班级名称");
            cells.Add(2, 3, "系部");
            cells.Add(2, 4, "年届");
            cells.Add(2, 5, "6S宿舍比例");
            cells.Add(2, 6, "当前名次");
            //foreach (AwardListClassDTO item in awardListClass)
            //{
            //    cells.Add(rowIndex, colIndex, i);
            //    cells.Add(rowIndex, colIndex + 1, item.CLASS);
            //    cells.Add(rowIndex, colIndex + 2, item.DEPARTMENT);
            //    cells.Add(rowIndex, colIndex + 3, item.YEAR);
            //    cells.Add(rowIndex, colIndex + 4, item.RATIO);
            //    cells.Add(rowIndex, colIndex + 5, item.RANK);
            //    rowIndex++;
            //    i++;
            //}
            doc.Send();
            Response.Flush();
            Response.End();
            //return File("", "application/ms-excel");
            //return null;
        }
        #endregion
    }
}