using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase {
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTest")]
    public String Get() {
        return "Hello World!";
    }

    [Route("/")]
    [HttpGet]
    public String GetRoot() {
        return "TestAPI";
    }
}