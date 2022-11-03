using Microsoft.AspNetCore.Mvc;

namespace Gr44EmptyMVC.Controllers
{
    public class DarthVaderController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(double temp) // overload 
        {
            if (temp != 0)
            {

                ViewBag.Msg = Models.DarthVader.TestForFever(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Pls enter your temperature and then hit Submit";
                return View();
            }
        }
        [HttpGet]
        public IActionResult FeverCheck()// overload
        {
            return View();
        }


    }
}
