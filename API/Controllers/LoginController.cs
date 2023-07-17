using EndProject.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult GetLogin(LoginInfo login)
        {
            return Ok();
        }
    }
}
