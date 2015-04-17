using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MD.WebApp.Startup))]
namespace MD.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
