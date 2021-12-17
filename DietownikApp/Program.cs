using DietownikApp;
using DietownikApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//// HttpClient for Local
//builder.Services.AddScoped(x =>
//{
//    return new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
//});

//// HttpClient for DietownikAPI
//var apiUrl = new Uri(builder.Configuration["DietownikAPI"]);

//builder.Services.AddScoped(sp =>
//{

//    return new HttpClient() { BaseAddress = apiUrl };

//});

//Console.WriteLine(apiUrl);


builder.Services.AddHttpClient<LocalService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<DietownikAPIService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["DietownikAPI"]);
});


await builder.Build().RunAsync();


public class Rootobject
{
    public Datum[] data { get; set; }
}

public class Datum
{
    public string date { get; set; }
    public int temperatureC { get; set; }
    public string summary { get; set; }
}
