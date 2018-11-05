using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(muestra.Startup))]
namespace muestra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
