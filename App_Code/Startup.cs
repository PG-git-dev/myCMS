using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite11.Startup))]
namespace WebSite11
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
