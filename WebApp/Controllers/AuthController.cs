﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return LocalRedirect("/Projects");
            //return View();
        }
    }
}
