using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GallowsGame.Models;

namespace GallowsGame.Controllers.View;

public class HomeController : Controller
{
    public HomeController()
    {
        
    }

    public IActionResult Index() => View();

    public IActionResult About() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}