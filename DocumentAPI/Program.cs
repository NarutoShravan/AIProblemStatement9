using Microsoft.AspNetCore.Hosting;
using DocumentAPI;
namespace DocumentAPI
{

public static class Program
 {
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    private static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(ConfigureWebHostDefaults);

    private static void ConfigureWebHostDefaults(IWebHostBuilder webHostBuilder)
    {
       // webHostBuilder.AddAppSettings();
        webHostBuilder.UseStartup<StartUp>();
    }
 }
}
