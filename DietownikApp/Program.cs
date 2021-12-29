using DietownikApp;
using DietownikApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


//builder.Services.AddHttpClient<LocalService>(client =>
//{
//    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
//});

//builder.Services.AddHttpClient<DietownikAPIService>(client =>
//{
//    client.BaseAddress = new Uri(builder.Configuration["DietownikAPI"]);
//});

builder.Services.AddScoped(x =>
{
    var apiUrl = new Uri(builder.Configuration["DietownikAPI"]);
    return new HttpClient() { BaseAddress = apiUrl };
});


var host = builder.Build();


await host.RunAsync();