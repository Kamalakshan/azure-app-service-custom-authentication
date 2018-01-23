using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Authentication;
using Owin;
using System.Configuration;
using System.Web.Http;

namespace CustomAuth_Api
{
    public partial class Startup
    {
        public static void ConfigureAuth(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            MobileAppSettingsDictionary settings = config.GetMobileAppSettingsProvider().GetMobileAppSettings();

            if (string.IsNullOrEmpty(settings.HostName))
            {
                // This middleware is intended to be used locally for debugging. By default, HostName will
                // only have a value when running in an App Service application.
                app.UseAppServiceAuthentication(new AppServiceAuthenticationOptions
                {
                    SigningKey = DebugAuthSettings.SigningKey,
                    ValidAudiences = new[] { DebugAuthSettings.ValidAudiences },
                    ValidIssuers = new[] { DebugAuthSettings.ValidIssuers },
                    TokenHandler = config.GetAppServiceTokenHandler()
                });
            }
        }
    }
}

