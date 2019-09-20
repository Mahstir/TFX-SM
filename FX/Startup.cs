using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FX.Startup))]
namespace FX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
