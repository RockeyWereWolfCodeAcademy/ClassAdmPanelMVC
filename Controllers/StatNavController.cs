﻿using Microsoft.AspNetCore.Mvc;

namespace SB_Admin.Controllers
{
    public class StatNavController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
