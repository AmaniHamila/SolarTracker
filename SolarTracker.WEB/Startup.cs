using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolarTracker.WEB.Startup))]
namespace SolarTracker.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
