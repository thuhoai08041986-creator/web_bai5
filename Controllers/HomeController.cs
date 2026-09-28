using Microsoft.AspNetCore.Mvc;

namespace WebProgramming.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}