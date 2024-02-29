using Microsoft.AspNetCore.Mvc;

namespace Rimando___QUIZ1.Controllers
{
    public class SplashController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
