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
        //GET used to ensure the page loads correctly before anything is submitted through POST. This can be observed in other pages, too
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
