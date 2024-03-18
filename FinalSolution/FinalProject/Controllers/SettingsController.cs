using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using FinalProject.Services;

namespace FinalProject.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserSettingsService _settingsService;

        public SettingsController(UserSettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var settings = _settingsService.GetSettings();
            return View(settings);
        }

        [HttpPost]
        public IActionResult Index(UserSettings settings)
        {
            _settingsService.UpdateSettings(settings);
            return RedirectToAction("Index");
        }
    }
}
