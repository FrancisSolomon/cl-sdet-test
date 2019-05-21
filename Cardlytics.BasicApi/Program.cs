using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using StructureMap.AspNetCore;

namespace Cardlytics.BasicApi
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost
                .CreateDefaultBuilder(args)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseStructureMap();
    }
}
