using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codefirst.Startup))]
namespace codefirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
