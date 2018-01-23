using System.Web.Http;
using System.Web.Http.Tracing;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Config;

namespace CustomAuth_MobileApi.Controllers
{
    // Use the MobileAppController attribute for each ApiController you want to use  
    // from your mobile clients 
    [MobileAppController]
    public class ProtectedController : ApiController
    {
        [Authorize]
        public string Get()
        {
            var settings = this.Configuration.GetMobileAppSettingsProvider().GetMobileAppSettings();
            var traceWriter = this.Configuration.Services.GetTraceWriter();

            string host = settings.HostName ?? "localhost";
            string greeting = "Hello from " + host;

            traceWriter.Info(greeting);

            return greeting;
        }
    }
}
