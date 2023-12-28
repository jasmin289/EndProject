using Microsoft.AspNetCore.Mvc;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories;
using Microsoft.AspNetCore.Cors;

namespace EndProject.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly IitemRepository itemRepo;
        public ItemsController(IConfiguration _Config, IitemRepository _itemRepo)
        {
            this.config = _Config ?? throw new ArgumentNullException(nameof(_Config));
            this.itemRepo = _itemRepo ?? throw new ArgumentNullException(nameof(_itemRepo));
        }
        [HttpGet("Items")]
        public IActionResult GetItems()
        {
            var result = itemRepo.FindAll().ToList();
            //TODO: only allow for admin user privileges
            // User users = new User();
            return Ok(result);
        }

        [HttpGet("getById/{id:int}")]
        public IActionResult GetItemByID(int id)
        {
            var result = itemRepo.FindByCondision(c => c.id == id).ToList();
            return Ok(result);
        }
        [HttpPost("AddUser")]
        public IActionResult AddItem(Items item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var newItem = itemRepo.Creat(item);

            return Created("item",newItem);
        }

        [HttpPut("update")]
        public IActionResult UpDateItem(Items item)
        {
            if (item == null) BadRequest();
            var exist = itemRepo.FindByCondision(x => x.id == item.id).Any();
            if (!exist) return NotFound();

            var newUser = itemRepo.Update(item);
            return Created("user", newUser);
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeletedItem(int id)
        {

            var item = itemRepo.FindByCondision(c => c.id == id).FirstOrDefault();

            if (item == null) return NotFound();
            itemRepo.Deleted(item);
            return NoContent();
        }
    }

}
