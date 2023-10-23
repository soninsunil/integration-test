using System;
using IntegrationTest.Model;
using IntegrationTest.Services.Interface;
using Microsoft.Extensions.Configuration;

namespace IntegrationTest;

public class App
{
    private readonly IMath _mathService;
    private readonly IConfiguration _configuration;
    
    public App(IMath mathService, IConfiguration configuration)
    {
        _mathService = mathService;
        _configuration = configuration;
    }

    public int Sum(string a, string b)
    {
        // version settings
        var version = _configuration["Version"];
        Console.WriteLine("version "  + version);
        
        // ApiSettings sections
        var apiSettings = _configuration.GetRequiredSection("ApplicationConfig").Get<ApplicationConfig>();
        Console.WriteLine("Github token "  + apiSettings.GitHubToken);
        Console.WriteLine("Bearer token "  + apiSettings.BearerToken);
        
        return _mathService.Add(1,3);
    }
}
