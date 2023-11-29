using Microsoft.AspNetCore.Mvc;

namespace SB_Admin.Controllers
{
    public class ChartController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
