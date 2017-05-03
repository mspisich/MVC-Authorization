using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab25.Startup))]
namespace Lab25
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
