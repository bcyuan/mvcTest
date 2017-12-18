using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 测试web
{
    public partial class 暂时测试 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //protected void Unnamed1_Click(object sender, EventArgs e)
        //{//E:\01lzf\Projects\测试web\测试web\img\1.jpg
        //    FileStream stream = new FileStream(Server.MapPath("/img/1.jpg"), FileMode.Open);
        //    long FileSize = stream.Length;
        //    byte[] Buffer = new byte[(int)FileSize];
        //    Response.ContentType = "image/jpg";
        //    stream.Read(Buffer, 0, (int)FileSize);
        //    stream.Close();
        //    //Response.BinaryWrite(Buffer);
        //    Response.Write(Buffer);
        //    //Response.Write(Server.MapPath(@"https://exp.bdstatic.com/static/common-jquery/widget/search-box/img/logo_83ae7e2.png"));
        //    //HttpResponse response = context.Response;  
        //}

        string qrcodeurl = "";
        string username = "";
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Button Btn = sender as Button;
            string commandArgument = Btn.CommandArgument.ToString();
            //生成图片  
            FileDownload(Server.MapPath("1zhodf保.jpg"));
            //FileDownload(@"https://exp.bdstatic.com/static/common-jquery/widget/search-box/img/logo_83ae7e2.png");
            //Response.WriteFile("1.jpg");
            //Response.Flush();
            //Response.End();
        
        }

       

        /// <summary>  
        /// 保存图片,在服务端  
        /// </summary>  
        /// <param name="strPath">保存路径</param>  
        /// <param name="img">图片</param>  
        public string SaveImg(string strPath, Bitmap img)
        {
            //保存图片到目录  
            if (!Directory.Exists(strPath))
            {
                //当前目录不存在，则创建  
                Directory.CreateDirectory(strPath);
            }
            //文件名称  
            string filename = strPath + "/" + username + ".png";
            if (File.Exists(filename))
            {
                return filename;
            }
            img.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            return filename;
        }

        /// <summary>
        /// webform另存图片,在客户端
        /// </summary>
        /// <param name="FullFileName"></param>
        private void FileDownload(string FullFileName)
        {
            FileInfo DownloadFile = new FileInfo(FullFileName);
            Response.Clear();
            Response.ClearHeaders();
            Response.Buffer = false;
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(DownloadFile.Name, System.Text.Encoding.UTF8));
            Response.AppendHeader("Content-Length", DownloadFile.Length.ToString());
            Response.WriteFile(DownloadFile.FullName);
            Response.Flush();
            Response.End();
        }
    }
}