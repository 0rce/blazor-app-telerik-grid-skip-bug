using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BlazorAppTelerikGridSkipBug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStaticWebAssets(); // may be needed when ASPNETCORE_ENVIRONMENT is NOT set to Development
                    webBuilder.UseSetting(WebHostDefaults.DetailedErrorsKey, "true"); // detailed server errors from circuits
                    webBuilder.UseStartup<Startup>();
                });
    }
}
