using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ClientApp.Client.Services;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace ClientApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            builder.Services.AddSingleton<IEquationService, EquationService>();
            builder.Services.AddSingleton<IAccountService, AccountService>();

            await builder.Build().RunAsync();
        }
    }
}
