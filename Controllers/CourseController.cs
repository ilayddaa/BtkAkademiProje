using System;
using Microsoft.AspNetCore.Mvc;
using BtkAkademiProje.Models;
using System.Reflection.Metadata.Ecma335;

namespace BtkAkademiProje.Controllers;
public class CourseController : Controller
{
    public IActionResult Index()
    {
        var model = Repository.Applications;
        return View(model);
    }

    public IActionResult Apply()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Apply([FromForm] Candidate model)
    {
        if (Repository.Applications.Any(x => x.Email == model.Email)) // eğer email adresi daha önce kayıt edilmişse hata ver
        {
            ModelState.AddModelError("Email", "This email is already registered");
        }
        if (ModelState.IsValid) // eğer model doğruysa
        {
            Repository.Add(model);
            return View("Feedback", model);
        }
        return View(model);
    }
}
