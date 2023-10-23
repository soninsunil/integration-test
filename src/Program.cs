using System;
using IntegrationTest;
using IntegrationTest.Services;
using IntegrationTest.Services.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var services = scope.ServiceProvider;

try
{
    var app = services.GetRequiredService<App>();
    var sumNumber = app.Sum(args[0],args[1]);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

IHostBuilder CreateHostBuilder(string[] strings)
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<IMath, CalcMath>();
            services.AddSingleton<App>();
        })
        .ConfigureAppConfiguration(app =>
        {
            app.AddJsonFile("appsettings.json");
        });
}
