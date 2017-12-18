using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
namespace 测试web
{
    public partial class 压缩文件 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void yasuo(object sender, EventArgs e)
        {
            ZipFiles(System.Web.HttpContext.Current.Server.MapPath("/data/"), "444", 5, "666", "777");
        }

        #region 制作压缩包（多个文件压缩到一个压缩包，支持加密、注释）
        /// <summary>
        /// 制作压缩包（多个文件压缩到一个压缩包，支持加密、注释）
        /// </summary>
        /// <param name="topDirectoryName">压缩文件目录</param>
        /// <param name="zipedFileName">压缩包文件名</param>
        /// <param name="compresssionLevel">压缩级别 1-9</param>
        /// <param name="password">密码</param>
        /// <param name="comment">注释</param>
        public void ZipFiles(string topDirectoryName, string zipedFileName, int compresssionLevel, string password, string comment)
        {
            using (ZipOutputStream zos = new ZipOutputStream(File.Open(zipedFileName, FileMode.OpenOrCreate)))
            {
                if (compresssionLevel != 0)
                {
                    zos.SetLevel(compresssionLevel);//设置压缩级别
                }

                if (!string.IsNullOrEmpty(password))
                {
                    zos.Password = password;//设置zip包加密密码
                }

                if (!string.IsNullOrEmpty(comment))
                {
                    zos.SetComment(comment);//设置zip包的注释
                }

                //循环设置目录下所有的*.jpg文件（支持子目录搜索）
                foreach (string file in Directory.GetFiles(topDirectoryName, "*.jpg", SearchOption.AllDirectories))
                {
                    if (File.Exists(file))
                    {
                        FileInfo item = new FileInfo(file);
                        FileStream fs = File.OpenRead(item.FullName);
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);

                        ZipEntry entry = new ZipEntry(item.Name);
                        zos.PutNextEntry(entry);
                        zos.Write(buffer, 0, buffer.Length);
                    }
                }
                FileInfo DownloadFile = new FileInfo(zipedFileName);
                Response.Clear();
                Response.ClearHeaders();
                Response.Buffer = false;
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(DownloadFile.Name, System.Text.Encoding.UTF8));
                Response.AppendHeader("Content-Length", DownloadFile.Length.ToString());
                Response.WriteFile(zipedFileName+".zip");
                //Response.BinaryWrite(System.Web.HttpContext.Current.Server.MapPath("/data/"));
                Response.Flush();
                Response.End();
            }

           // 
           


        }
        #endregion
    }
}