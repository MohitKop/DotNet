using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteLNR.Startup))]
namespace WebSiteLNR
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
