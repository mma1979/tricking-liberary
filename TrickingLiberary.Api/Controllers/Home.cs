using Microsoft.AspNetCore.Mvc;

namespace TrickingLiberary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Home: ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World";
        }
    }
}