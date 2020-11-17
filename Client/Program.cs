using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ClientApp.Client.Services;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using ClientApp.Client.Interfaces;

namespace ClientApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            //builder.Services.AddSyncfusionBlazor();
            //SyncfusionLicenseProvider.RegisterLicense("MjY4ODE4QDMxMzgyZTMxMmUzMENQVmgyNVMrenZmZ2ZIb0ZqaE53M1AzVk9qV01hbHpMUGR4VkV2RlVrZEk9");
            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IEquationService, EquationService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITransactionService, TransactionService>();
        }
    }
}
