using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine($"User {model.Username} registered successfully.");
                
                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed; redisplay the form.
            return View(model);
        }
    }
}
