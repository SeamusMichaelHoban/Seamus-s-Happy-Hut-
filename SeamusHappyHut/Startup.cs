using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeamusHappyHut.Startup))]
namespace SeamusHappyHut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
