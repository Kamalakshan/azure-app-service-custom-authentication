using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CustomAuth_MobileApi.Startup))]

namespace CustomAuth_MobileApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}