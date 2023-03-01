using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class DishController : Controller
{
    private MyContext db;

    public DishController(MyContext context)
    {
        db = context;
    }

    [HttpGet("dish/{id}")]
    public IActionResult Info(int id)
    {
        Dish? ViewDish = db.Dishes.FirstOrDefault(i => i.DishId == id);
        if (ViewDish != null)
        {
            return View(ViewDish);
        }
        else
        {
            return RedirectToAction("Index");
        }
    }

    [HttpGet("/dish/new")]
    public IActionResult AddDish() {
        return View();
    }
    [HttpPost("/dish/createDish")]
    public IActionResult CreateDish(Dish d) {
        if (ModelState.IsValid) {
            db.Dishes.Add(d);
            db.SaveChanges();
            Console.WriteLine(s.DishId);
            return Redirect("");
            // we would want to use ViewBag if we were to say "You have successfully added a new squishy after submit"
        } else {
            return View("AddDish");
        }
    }
}
