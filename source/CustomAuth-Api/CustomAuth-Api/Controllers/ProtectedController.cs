using System.Web.Http;

namespace CustomAuth_Api.Controllers
{
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
