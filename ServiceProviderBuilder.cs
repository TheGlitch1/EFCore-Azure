
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTuto
{
   public static class  ServiceProviderBuilder
    {
        public static IServiceProvider GetServiceProvider(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .AddUserSecrets(typeof(Program).Assembly)
                .AddCommandLine(args)
                .Build();
            var services = new ServiceCollection();

            services.Configure<EFCoreTutoSetting>(configuration.GetSection("EFCoreTutoSetting"));
                   

            var provider = services.BuildServiceProvider();
            return provider;
        }
    }
}
