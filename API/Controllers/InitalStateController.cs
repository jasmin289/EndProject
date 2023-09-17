using Microsoft.AspNetCore.Mvc;

namespace EndProject.API.Controllers
{
    public class InitalStateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
