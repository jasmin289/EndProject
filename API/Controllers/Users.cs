using EndProject.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Users : Controller
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            //TODO: only allow for admin user privileges
            Users users = new Users();  
            return Ok(users);
        }

        [HttpGet]
        public IActionResult GetUser(int id) {
            return Ok();
          }
        [HttpPost]
        public IActionResult AddUsers(User users)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpDateUser(User users)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletedUser(User users)
        {
            return Ok();
        }

    }
}
