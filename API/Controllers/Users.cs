using EndProject.API.Models.DTO;
using EndProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.API.Controllers
{

    [ApiController]
    [Route("[controller]")]


    public class Users : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly IUserRepository userRepo;
        public Users(IConfiguration _config, IUserRepository _userRepo)
        {
            this.config = _config ?? throw new ArgumentNullException(nameof(_config));
            this.userRepo = _userRepo ?? throw new ArgumentNullException(nameof(_userRepo));
        }
        [HttpGet("getAllUsers")]
        public IActionResult GetUsers()
        {
         var result = userRepo.FindAll().ToList();
            //TODO: only allow for admin user privileges
           // User users = new User();
            return Ok(result);
        }

        [HttpGet("getById/{id:int}")]
        public IActionResult GetUserByID(int id)
        {
            var result = userRepo.FindByCondision(c => c.ID == id).ToList();
            return Ok(result);
        }
        [HttpPost("AddUser")]
        public IActionResult AddUsers(User users)
        {
            if(users == null)
            {
                return BadRequest();
            }
            var newUser =  userRepo.Creat(users);

            return Created("user",newUser);
        }

        [HttpPut("update")]
        public IActionResult UpDateUser(User users)
        {
           if(users == null)  BadRequest();
           var exist = userRepo.FindByCondision(x=>x.ID == users.ID).Any();
            if(!exist) return NotFound();
         
            var newUser = userRepo.Update(users);
            return Created("user",newUser); 
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeletedUser(int id)
        {
           
            var user = userRepo.FindByCondision(c => c.ID == id).FirstOrDefault();
         
            if(user == null) return NotFound();
            userRepo.Deleted(user);
            return NoContent();
        }
    }

}
