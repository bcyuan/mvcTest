using System.Web.Mvc;

namespace 测试web.Areas.export测试
{
    public class export测试AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "export测试";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "export测试_default",
                "export测试/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}