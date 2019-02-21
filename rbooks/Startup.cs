using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rbooks.Startup))]
namespace rbooks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
