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


            /*
             * var services = ServiceProviderBuilder.GetServiceProvider(args);
            var options = services.GetRequiredService<IOptions<EFCoreTutoSetting>>();*/

            /*var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddUserSecrets<Program>()
               .AddEnvironmentVariables();*/

            /* IConfigurationRoot configuration = builder.Build();
             var mySettingsConfig = new EFCoreTutoSetting();
             configuration.GetSection("MySettings").Bind(mySettingsConfig);*/

            /*Console.WriteLine("connectionString:   " + options.Value.ConnectionString);
            Console.WriteLine("pwd: " + options.Value.PwdSqlAzure);
            Console.WriteLine("user: " + options.Value.UserSqlAzure);
            Console.WriteLine("Account Name: " + options.Value.AccountName);
            Console.WriteLine("ApiKey: " + options.Value.ApiKey);*/

            /*using (var context = new EFCoreContext())
            {
                Console.WriteLine()
            }*/


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
