using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlacementCountdown.Startup))]
namespace PlacementCountdown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
