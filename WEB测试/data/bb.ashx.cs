using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace 测试web
{
    /// <summary>
    /// bb 的摘要说明
    /// </summary>
    public class bb : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //FileDownload(context, System.Web.HttpContext.Current.Server.MapPath("/data/1zhodf保.jpg"));

            var ss = "/data/1.jpg";
            ss += "|/data/2.jpg";
            ZipFileDownload(context,ss.Split('|'), DateTime.Now.ToString("yyyyMMddhhMmss") + "_检品报告书.zip"); 

            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
        }
        private void FileDownload(HttpContext context,string FullFileName)
        {
            //FileInfo DownloadFile = new FileInfo(FullFileName);
            //context.Response.Clear();
            //context.Response.ClearHeaders();
            //context.Response.Buffer = false;
            //context.Response.ContentType = "application/octet-stream";
            //context.Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(DownloadFile.Name, System.Text.Encoding.UTF8));
            //context.Response.AppendHeader("Content-Length", DownloadFile.Length.ToString());
            //context.Response.WriteFile(DownloadFile.FullName);
            //context.Response.Flush();
            //context.Response.End();

            //string filename;
            //try
            //{
            //    filename = context.Request["filename"].ToString();
            //}
            //catch
            //{
            //    context.Response.Write("不正确的访问！");
            //    return;
            //}
            //string RealFile = context.Server.MapPath("~/Upload/files/" + filename);//真实存在的文件
            //if (!System.IO.File.Exists(RealFile))
            //{
            //    context.Response.Write("服务器上该文件已被删除或不存在！"); return;
            //}
            context.Response.Buffer = true;
            context.Response.Clear();
            context.Response.ContentType = "application/download";
            string downFile = System.IO.Path.GetFileName("555");//这里也可以随便取名
            string EncodeFileName = HttpUtility.UrlEncode(downFile, System.Text.Encoding.UTF8);//防止中文出现乱码
            context.Response.AddHeader("Content-Disposition", "attachment;filename=" + EncodeFileName + ";");
            context.Response.BinaryWrite(System.IO.File.ReadAllBytes(FullFileName));//返回文件数据给客户端下载
            context.Response.Flush();
            context.Response.End();
        }

        /// <summary>  
        ///  批量进行多个文件压缩到一个文件  
        /// </summary>  
        /// <param name="files">文件列表(绝对路径)</param> 这里用的数组，你可以用list 等或者  
        /// <param name="zipFileName">生成的zip文件名称</param>  
        private void ZipFileDownload(HttpContext context,string[] files, string zipFileName)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buffer = null;

            using (ZipFile file = ZipFile.Create(ms))
            {
                file.BeginUpdate();

                file.NameTransform = new MyNameTransfom();
                foreach (var item in files)
                {
                    if (File.Exists(context.Server.MapPath(item)))
                        file.Add(context.Server.MapPath(item));

                }
                file.CommitUpdate();
                buffer = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(buffer, 0, buffer.Length);   //读取文件内容(1次读ms.Length/1024M)  
                ms.Flush();
                ms.Close();
            }
            context.Response.Clear();
            context.Response.Buffer = true;
            context.Response.ContentType = "application/x-zip-compressed";
            context.Response.AddHeader("content-disposition", "attachment;filename=" + HttpUtility.UrlEncode(zipFileName));
            context.Response.BinaryWrite(buffer);
            context.Response.Flush();
            context.Response.End();
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}