using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CodeTech.Web.App.Models;

namespace CodeTech.Web.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            RegisterServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddBaseAddressHttpClient();
            services.AddSingleton<IEnumerable<MenuLink>>(new List<MenuLink>
            {
                new MenuLink("Unique identifiers", "/uid"),
                new MenuLink("Random person data", "/person"),
                new MenuLink("OAuth", "/oauth")
            });
        }
    }
}
