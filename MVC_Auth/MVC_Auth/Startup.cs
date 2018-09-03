using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Auth.Startup))]
namespace MVC_Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
