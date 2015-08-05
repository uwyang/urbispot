using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(urbispot.Startup))]
namespace urbispot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
