using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AowenPlatform.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:29999")
                .UseStartup<Startup>()
                .Build();
        }
    }
}
