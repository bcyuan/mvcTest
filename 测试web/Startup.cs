using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(测试web.Startup))]
namespace 测试web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
