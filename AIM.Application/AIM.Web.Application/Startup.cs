using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIM.Web.Application.Startup))]
namespace AIM.Web.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
