using GallowsGame.Interfaces;
using GallowsGame.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("[controller]")]
public class GameController : Controller
{
    private readonly IGameService _game;

    public GameController(IGameService game)
    {
        _game = game;
    }
    
    /// <summary>
    /// Get game
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<GameDto> Get(Guid? id) => await _game.GetGame(id);

    /// <summary>
    /// Get all game
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IEnumerable<GameDto>> GetAll() => await _game.GetAllGame();

    /// <summary>
    /// Post game
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<GameDto> Post() =>  new GameDto();
    
    /// <summary>
    /// Put game
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<GameDto> Put() => new GameDto();
    
    /// <summary>
    /// Delete game
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public async Task<bool> Delete() => true;
}