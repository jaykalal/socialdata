using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Social_app.Startup))]
namespace Social_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
