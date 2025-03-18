using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            var loginForm = new LoginFormModel();
            return View(loginForm);
        }

        [HttpPost]
        public IActionResult Login(LoginFormModel loginForm)
        {
            if (!ModelState.IsValid)
                return View(loginForm);
            return View();
        }
    }
}
