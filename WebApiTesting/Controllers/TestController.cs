using Microsoft.AspNetCore.Mvc;

namespace WebApiTesting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "I'm alive!";
        }

        [HttpGet("HelloWorld", Name = "HelloWorld")]
        public string GetHelloWorld()
        {
            return "Hello World";
        }
    }
}
