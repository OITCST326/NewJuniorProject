using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIM.Admin.Web.Startup))]
namespace AIM.Admin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
