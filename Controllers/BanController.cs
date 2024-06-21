using Microsoft.AspNetCore.Mvc;

namespace Webbanhang.Controllers
{
    public class BanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult hienThi()
        {
            return View();
        }
    }
}
