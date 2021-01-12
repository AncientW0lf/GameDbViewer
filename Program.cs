using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace GameDbViewer
{
    public class Program
    {
        public static GameDb GameDb { get; private set; }

        public static void Main(string[] args)
        {
            GameDb = new GameDbLoader().Load();

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
