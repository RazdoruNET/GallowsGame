using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.View;

public class GamesController : Controller
{
    private readonly ILogger<GamesController> _logger;

    public GamesController(ILogger<GamesController> logger)
    {
        _logger = logger;
    }

    public IActionResult List()
    {
        return View();
    }
}