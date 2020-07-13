using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eorderOne.Startup))]
namespace eorderOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
