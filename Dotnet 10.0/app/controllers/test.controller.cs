
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController: ControllerBase
{
    [HttpGet]
    public ActionResult<string> SayHelloWorld()
    {
        return Ok(new {message = "Hello World"});
    }
}

