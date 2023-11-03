using Microsoft.AspNetCore.Mvc;

namespace lab3._2.Controllers
{
    public class DatabaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
