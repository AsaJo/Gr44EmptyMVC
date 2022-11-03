using Microsoft.AspNetCore.Mvc;

namespace Gr44EmptyMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
