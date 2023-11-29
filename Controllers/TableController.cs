﻿using Microsoft.AspNetCore.Mvc;

namespace SB_Admin.Controllers
{
    public class TableController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var dt = await Helpers.SqlHelper.GetDatas("SELECT * FROM Actors");
            return View(dt);
        }
    }
}
