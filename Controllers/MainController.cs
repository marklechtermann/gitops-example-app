using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace gitops_example_app.Controllers;

[ApiController]
[Route("/")]
public class MainController : ControllerBase
{
    public Info GetVersion()
    {
        var informationalVersion = typeof(MainController).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
        return new Info() { Version = informationalVersion?.InformationalVersion };
    }
}

public class Info
{
    public string? Version { get; set; }
}
