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
    [HttpGet("")] 
    public IActionResult Dashboard() {
        List<Dish> allDishes = db.Dishes.ToList();
        return View("Dashboard", allDishes);
    }

    [HttpGet("dish/{dishId}/view")]
    public IActionResult ViewProject(int dishId) {
        Dish? dish = db.Dishes.FirstOrDefault(dish => dish.DishId == dishId);

        if(dish == null) {
            return RedirectToAction("dashboard");
        } else {
            return View("ViewDish", dish);
        }
    }

    [HttpGet("/dish/addDish")]
    public IActionResult AddDish() {
        return View();
    }
    [HttpPost("/dish/createDish")]
    public IActionResult CreateDish(Dish d) {
        if (ModelState.IsValid) {
            db.Dishes.Add(d);
            db.SaveChanges();
            Console.WriteLine(d.DishId);
            return Redirect("/");
            // we would want to use ViewBag if we were to say "You have successfully added a new squishy after submit"
        } else {
            return View("AddDish");
        }
    }
}
