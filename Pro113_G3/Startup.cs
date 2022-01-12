using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pro113_G3.Startup))]
namespace Pro113_G3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
