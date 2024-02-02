using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class HelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
