using Microsoft.AspNetCore.Mvc;

namespace PodTalk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
