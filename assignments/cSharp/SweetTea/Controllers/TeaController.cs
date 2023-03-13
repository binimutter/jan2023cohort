using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SweetTea.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace SweetTea.Controllers;

public class TeaController : Controller
{
    private MyContext db;         
    public TeaController(MyContext context)    
    {        
        db = context;    
    }

    [LoginCheck]
    [HttpGet("/teas")]
    public IActionResult All()
    {
        // List<Art> arts = db.Arts.Include(a => a.Creator).Include(a => a.Likes).OrderByDescending(a => a.UpdatedAt).ToList();
        return View("All");
    }
}

public class LoginCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        // Find the session, but remember it may be null so we need int?
        int? userId = context.HttpContext.Session.GetInt32("UUID");
        // Check to see if we got back null
        if(userId == null)
        {
            // Redirect to the Index page if there was nothing in session
            // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
            context.Result = new RedirectToActionResult("Index", "Home", null);
        }
    }
}