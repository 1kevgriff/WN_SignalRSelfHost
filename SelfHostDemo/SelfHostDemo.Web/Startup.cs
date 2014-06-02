using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelfHostDemo.Web.Startup))]
namespace SelfHostDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
