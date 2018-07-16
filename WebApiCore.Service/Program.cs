using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApiCore.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create web application host
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
