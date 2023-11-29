using Microsoft.AspNetCore.Mvc;

namespace SB_Admin.Controllers
{
    public class LightNavController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
