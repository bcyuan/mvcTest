using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB测试.缓存
{
    public partial class 缓存 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var a = HttpContext.Current.Request.Cookies["cookie_areaJonsString"].Value.ToString();
            var c = HttpContext.Current.Request.Cookies["cookie_areaJson"].Value.ToString();
            //a=%7B%7Bname%3A'%E4%B8%AD%E5%9B%BD'%2Cprovince%3A%5B%7Bname%3A'%E9%BB%91%E9%BE%99%E6%B1%9F'%2Ccities%3A%7Bcity%3A%5B'%E5%93%88%E5%B0%94%E6%BB%A8'%2C'%E5%A4%A7%E5%BA%86'%5D%7D%2C%7Bname%3A'%E5%B9%BF%E4%B8%9C'%2Ccities%3A%7Bcity%3A%5B'%E5%B9%BF%E5%B7%9E'%2C'%E6%B7%B1%E5%9C%B3'%2C'%E7%8F%A0%E6%B5%B7'%5D%7D%7D
            var a1 = HttpContext.Current.Server.UrlDecode(a);
            var c1 = HttpContext.Current.Server.UrlDecode(c);
            //a1={{name:'中国',province:[{name:'黑龙江',cities:{city:['哈尔滨','大庆']},{name:'广东',cities:{city:['广州','深圳','珠海']}}
            var c3 = HttpContext.Current.Server.UrlDecode(HttpContext.Current.Request.Cookies["cookie_3"].Value.ToString());//101,102,103
        }
    }
}