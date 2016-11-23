using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gittestproject.Startup))]
namespace gittestproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
