using Microsoft.AspNetCore.Mvc;
namespace api.Controllers;
[ApiController]
[Route("/")]
public class MainController : ControllerBase
{
    [HttpGet(Name = "/")]
    public string Get()
    {
        string message = "Hi Devs! Welcome to .NET Conf 2023 Khujand.";
        return $"V1: {message}";
    }
}