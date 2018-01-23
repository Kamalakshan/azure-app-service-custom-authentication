using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CustomAuth_Api.Startup))]

namespace CustomAuth_Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}