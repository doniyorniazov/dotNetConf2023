using Microsoft.AspNetCore.Mvc;
namespace api.Controllers;
[ApiController]
[Route("/")]
public class MainController : ControllerBase
{
    [HttpGet(Name = "/")]
    public string Get()
    {
        string message = "Hi Devs! Welcome to .NET Conf 2023 Khujand. This is new UPDATE!";
        return $"V2: {message}";
    }
}