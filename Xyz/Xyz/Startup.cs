using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xyz.Startup))]
namespace Xyz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
