using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DivorceLaw.Startup))]
namespace DivorceLaw
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
