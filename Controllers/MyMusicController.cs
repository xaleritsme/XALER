using Microsoft.AspNetCore.Mvc;

namespace XALER.Controllers
{
    public class MyMusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
