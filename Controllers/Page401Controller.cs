using Microsoft.AspNetCore.Mvc;

namespace SB_Admin.Controllers
{
    public class Page401Controller : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
