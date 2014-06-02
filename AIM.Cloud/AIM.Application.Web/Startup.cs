using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIM.Application.Web.Startup))]
namespace AIM.Application.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
