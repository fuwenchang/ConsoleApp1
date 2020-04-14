using System;
using System.IO;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Autofac";
            CreateHostBuilder(args).Run();
        }

        public static IWebHost CreateHostBuilder(string[] args) 
        {
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services => services.AddAutofac())
                .UseKestrel()
                .UseStartup<Startup>()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration((builderContext, config) =>
                {
                    config.AddJsonFile($"appsettings.{builderContext.HostingEnvironment.EnvironmentName}.json", false, true);

                   
                }).Build();
        }
    }
}
