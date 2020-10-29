using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_5.Startup))]
namespace TMDT_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
