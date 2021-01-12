using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace GameDbViewer
{
    public class Program
    {
        public GameDbLoader Loader { get; } = new GameDbLoader();

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://*:80");
                });
    }
}
