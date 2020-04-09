using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Kidcon.Client.Services;

namespace Kidcon.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(s =>
            {
                return new HttpClient()
                {
                    BaseAddress = new Uri("https://kidcon-api.azurewebsites.net")
                };
            });

            builder.Services.AddSingleton<IEquationService, EquationService>();
            builder.Services.AddSingleton<IAccountService, AccountService>();

            await builder.Build().RunAsync();
        }
    }
}
