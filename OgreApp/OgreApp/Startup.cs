using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OgreApp.Startup))]
namespace OgreApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
