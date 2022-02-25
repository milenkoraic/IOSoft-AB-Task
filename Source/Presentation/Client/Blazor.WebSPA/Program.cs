using Blazor.WebSPA.ViewModels;
using Domain.Service;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.WebSPA
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<CustomerOrderViewModel>();
            builder.Services.AddTransient<IFruitPressService, FruitPressResult>();
            builder.Services.AddSingleton<IRecipeService, RecipeService>();

            await builder.Build().RunAsync();
        }
    }
}
