using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Widly.Startup))]
namespace Widly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
