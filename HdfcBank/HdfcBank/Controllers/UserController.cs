using Microsoft.AspNetCore.Mvc;

namespace HdfcBank.Controllers
{
    [ApiController]
    [Route("")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("/transfer")]
        public IActionResult Transfer([FromQuery] int amount, string to)
        {
            return Ok($"Amount Transferred to {to}");
        }

        [HttpGet]
        [Route("")]
        public IActionResult Hello()
        {
            return Ok("Hello");
        }

    }
}
