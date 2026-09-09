using Microsoft.AspNetCore.Mvc;

namespace RouterWithoutMVC.Properties.controller
{
    public class HomeController : Controller
        
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult  Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
