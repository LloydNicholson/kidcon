using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using KidConDual.Client.Services;

namespace KidConDual.Client
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
                    BaseAddress = new Uri("http://localhost:5002")
                };
            });

            builder.Services.AddSingleton<IEquationService, EquationService>();
            builder.Services.AddSingleton<IAccountService, AccountService>();

            await builder.Build().RunAsync();
        }
    }
}
