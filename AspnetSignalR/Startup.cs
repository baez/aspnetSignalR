using System.Diagnostics;

using Microsoft.AspNet.SignalR;
using Microsoft.Owin;

using Owin;

[assembly: OwinStartup(typeof(AspnetSignalR.Startup))]

namespace AspnetSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapAzureSignalR(this.GetType().FullName);

            // Turn tracing on programmatically
            GlobalHost.TraceManager.Switch.Level = SourceLevels.Information;
        }
    }
}
