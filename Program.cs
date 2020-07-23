using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.IO;

namespace EFCoreTuto
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {
            
            var devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            var isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) || devEnvironmentVariable.ToLower() == "development";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            if (isDevelopment) //only add secrets in development
            {
                builder.AddUserSecrets<EFCoreTutoSetting>();
            }

            Configuration = builder.Build();

            var services = new ServiceCollection()
               .Configure<EFCoreTutoSetting>(Configuration.GetSection(nameof(EFCoreTutoSetting)))
               .AddOptions()
               .BuildServiceProvider();

            services.GetService<EFCoreTutoSetting>();
            
            using (var context = new EFCoreContext(services.GetRequiredService<IOptions<EFCoreTutoSetting>>()))
            {
                Console.WriteLine("available status: "+context.Database.CanConnect());
            }

            Console.ReadLine();
        }
    }
}
