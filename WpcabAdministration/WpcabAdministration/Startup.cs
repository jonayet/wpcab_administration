using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WpcabAdministration.Startup))]
namespace WpcabAdministration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
