﻿using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            TempData["Title"] = "Team";
            return View();
        }
    }
}
