using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;

namespace CRUD.Controllers;

public class TuneController : Controller
{
    private MyContext db;

    public TuneController(MyContext context)
    {
        db = context;
    }
    [HttpGet("/tune/alltunes")]
    public IActionResult AllTunes() {
        List<Tune> allTunes = db.Tunes.ToList();
        return View("AllTunes", allTunes);
    }

}
