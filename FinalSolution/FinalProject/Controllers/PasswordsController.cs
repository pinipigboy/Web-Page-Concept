using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using FinalProject.Services;
using System.Diagnostics;

public class PasswordsController : Controller
{
    private readonly MockPasswordService _passwordService;
    
    public PasswordsController(MockPasswordService passwordService)
    {
        _passwordService = passwordService;
    }
    // Another GET form along with more POST forms are down below
    [HttpGet]
    public IActionResult Index(string search)
    {
        var passwords = _passwordService.GetAll();
        Debug.WriteLine($"Password count: {passwords.Count()}");
        if (!string.IsNullOrEmpty(search))
        {
            passwords = passwords.Where(p =>
            (p.Website != null && p.Website.Contains(search, StringComparison.OrdinalIgnoreCase)) ||
            (p.Username != null && p.Username.Contains(search, StringComparison.OrdinalIgnoreCase))
            ).ToList();

        }

        return View(passwords);
    }

    [HttpPost]
    public IActionResult Add(PasswordEntry entry)
    {
        Debug.WriteLine($"Adding entry: {entry.Website}, {entry.Username}, {entry.Password}");
        _passwordService.Add(entry);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _passwordService.Delete(id);
        return RedirectToAction("Index");
    }
}
