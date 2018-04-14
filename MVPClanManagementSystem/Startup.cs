using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVPClanManagementSystem.Startup))]
namespace MVPClanManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
