using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BehafarinClinic.Startup))]
namespace BehafarinClinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
