using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    //It should be noted that this registration page technically doesn't do anything. I really only implemented it to show off POST and debugging.
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
                // Debug statements to log each piece of submitted information
                Debug.WriteLine($"Registration Timestamp: {DateTime.Now}");
                Debug.WriteLine($"Username: {model.Username}");
                Debug.WriteLine($"Email: {model.Email}");
                Debug.WriteLine($"Password: {model.Password}"); 
                Debug.WriteLine($"Confirm Password: {model.ConfirmPassword}"); 
                Debug.WriteLine($"Birthday: {model.Birthday.ToString("yyyy-MM-dd")}");

                // Proceed with the registration process
                return RedirectToAction("Index", "Home");
            }

            // If we get here, something failed; redisplay the form with validation messages
            return View(model);
        }
    }
}
