using ASP_WEB_DocumentReader;
using ASP_WEB_DocumentReader.Domain.Core.Interfaces;
using ASP_WEB_DocumentReader.Infra.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ILoginService, LoginService>()
                .AddScoped<IAlertService, AlertService>()
                .AddScoped<ILocalStorageService, LocalStorageService>();

builder.Services.AddScoped(x => {
    var apiUrl = new Uri(builder.Configuration["apiUrl"]);

   
    return new HttpClient() { BaseAddress = apiUrl };
});

var host = builder.Build();

var accountService = host.Services.GetRequiredService<ILoginService>();

await accountService.Initialize();

await host.RunAsync();
