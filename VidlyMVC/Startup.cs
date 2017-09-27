using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMVC.Startup))]
namespace VidlyMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
