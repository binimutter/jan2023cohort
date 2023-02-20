using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Controllers;
public class HomeController : Controller
{
    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
    // Route declaration Option B
    // This will go to "localhost:5XXX/projects"
    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my projects";
    }

    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my Contact!";
    }
}