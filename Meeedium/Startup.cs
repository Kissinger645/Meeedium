using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Meeedium.Startup))]
namespace Meeedium
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
