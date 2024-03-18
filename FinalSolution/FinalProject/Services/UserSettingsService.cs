using FinalProject.Models;

namespace FinalProject.Services
{
    public class UserSettingsService
    {
        private UserSettings _currentSettings = new UserSettings();

        public UserSettings GetSettings() => _currentSettings;

        public void UpdateSettings(UserSettings settings) => _currentSettings = settings;
    }
}