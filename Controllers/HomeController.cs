using System;
using Microsoft.AspNetCore.Mvc;

namespace CinemaPandas.Controllers 
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(string Title, int Year, string Genre, string Description)
        {
            Console.WriteLine($"{Title} | {Year} | {Genre} | {Description}");
            
            // In the future, we'd like to redirect instead
            // but for now we'll return a view
            // return Redirect("/");
            // return RedirectToAction("Index");
            ViewBag.Title = Title;
            ViewBag.Year = Year;
            ViewBag.Genre = Genre;
            ViewBag.Description = Description;
            return View("Results");
        }
    }
}