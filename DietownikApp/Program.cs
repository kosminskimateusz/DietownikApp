using DietownikApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiUrl = new Uri(builder.Configuration["DietownikAPI"]);

builder.Services.AddScoped(sp =>
{
    
    return new HttpClient() { BaseAddress = apiUrl };

});

Console.WriteLine(apiUrl);

await builder.Build().RunAsync();
