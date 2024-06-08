using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase    
    {
        [HttpGet]
        public IActionResult HelloWorld()
        {
            return Ok("Hellow");
        }
    }
}
