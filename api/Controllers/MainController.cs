using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("/")]
public class MainController : ControllerBase
{

    [HttpGet(Name = "/")]
    public string Get()
    {
        string? message = "Hi Devs! Welcome to .NET Conf 2023 Khujand.";
        message = string.IsNullOrEmpty(message) ? "No version: No environment variable specified. Please specify MESSAGE environment variable." : message;

        return $"V2: {message}";
    }
}