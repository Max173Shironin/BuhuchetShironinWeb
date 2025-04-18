using Microsoft.AspNetCore.Mvc;

namespace BuhuchetShironin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
