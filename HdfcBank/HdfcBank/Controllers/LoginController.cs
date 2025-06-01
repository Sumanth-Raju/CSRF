using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HdfcBank.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        [Route("/login")]
        public async Task<IActionResult> Login([FromQuery] string userName, [FromQuery] string password)
        {
            if (userName.Equals("admin") && password.Equals("admin"))
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, userName));
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return Ok("USer Authenticated");
            }
            return BadRequest("User not found");
        }
    }
}
