using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_adminlte_integration.Startup))]
namespace test_adminlte_integration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
