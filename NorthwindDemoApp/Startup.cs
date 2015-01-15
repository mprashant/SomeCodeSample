using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindDemoApp.Startup))]
namespace NorthwindDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
