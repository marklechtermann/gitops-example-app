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
        var git_sha = Environment.GetEnvironmentVariable("GIT_SHA");
        return new Info()
        {
            Version = informationalVersion?.InformationalVersion,
            GitSHA = git_sha,
            Description = "Hello 123 dev 123",
            Secret = Environment.GetEnvironmentVariable("MYSECRET")
        };
    }
}

public class Info
{
    public string? Version { get; set; }
    public string? GitSHA { get; set; }
    public string? Description { get; set; }
    public string? Secret { get; set; }
}
