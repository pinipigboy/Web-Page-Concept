using System.Collections.Generic;
using System.Linq;
using FinalProject.Models; // Ensure this matches the namespace of your models

namespace FinalProject.Services
{
    // Services/MockPasswordService.cs
    public class MockPasswordService
    {
        private List<PasswordEntry> _passwordEntries = new List<PasswordEntry>();
        private int _nextId = 1;

        public IEnumerable<PasswordEntry> GetAll() => _passwordEntries;

        public void Add(PasswordEntry entry)
        {
            entry.Id = _nextId++;
            _passwordEntries.Add(entry);
        }

        public void Delete(int id)
        {
            var entry = _passwordEntries.FirstOrDefault(e => e.Id == id);
            if (entry != null)
            {
                _passwordEntries.Remove(entry);
            }
        }
    }
}
