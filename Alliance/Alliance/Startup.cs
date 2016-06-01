using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alliance.Startup))]
namespace Alliance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
