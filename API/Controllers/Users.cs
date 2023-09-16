using EndProject.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.API.Controllers
{

    [ApiController]
    [Route("[controller]")]


    public class Users : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            //TODO: only allow for admin user privileges
            Users users = new Users();
            return Ok(users);
        }

        [HttpGet("GetById")]
        public IActionResult GetUserByID(int id)
        {
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
