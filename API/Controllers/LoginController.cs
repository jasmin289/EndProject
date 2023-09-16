using EndProject.API.Models;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EndProject.API.Controllers
{
   [ApiController]
   [Route("api/[Controller]")]
    public class LoginController : Controller
    {
        private readonly IConfiguration config;
        private readonly IUserRepository userRepo;
        public LoginController(IConfiguration _config, IUserRepository _userRepo)
        {
           this.config = _config?? throw new ArgumentNullException(nameof(_config));
           this.userRepo = _userRepo?? throw new ArgumentNullException(nameof(_userRepo));
        } 
        [HttpPost]
        public IActionResult GetToken(LoginInfo login)
        {
            if (login == null) return BadRequest();
 
            User  user = userRepo.FindByCondision(
                u=>u.UserName == login.UserName  && 
                u.Password== login.Password).FirstOrDefault();
            if (user == null)  return Unauthorized();

            var kye = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(config["Authentication:Secret"] ?? throw new ArgumentNullException("Authentication: Secret")));
            
            var cred = new SigningCredentials(kye,SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new Claim("sub",user.ID.ToString())
            };

            string ValidAudience = config["Authentication:Audience"] ?? throw new ArgumentNullException("Authentication:Audience");
            string ValidIssuer = config["Authentication:Issuer"] ?? throw new ArgumentNullException("Authentication:Issuer");

            var token = new JwtSecurityToken(
                ValidIssuer, 
                ValidAudience,
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddDays(1)
                );
            var tokenStr = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(tokenStr);
        }
    }
}


//public IActionResult GetLogin(LoginInfo login)
//{
//    return Ok();
//}