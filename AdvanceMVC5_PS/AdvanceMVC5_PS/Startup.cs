using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdvanceMVC5_PS.Startup))]
namespace AdvanceMVC5_PS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
