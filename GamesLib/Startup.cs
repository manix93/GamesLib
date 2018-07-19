using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamesLib.Startup))]
namespace GamesLib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
