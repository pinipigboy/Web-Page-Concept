using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class SettingsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // For demonstration, settings are predefined.
            // In a real scenario, you'd retrieve these from a database or user session.
            var settings = new UserSettings
            {
                EnableNotifications = true // Default setting
            };

            return View(settings);
        }

        [HttpPost]
        public IActionResult Index(UserSettings settings)
        {
            // Here, you would save the settings back to the database or user session.
            // For demonstration, just log the action and redirect.
            return RedirectToAction("Index");
        }
    }
}
