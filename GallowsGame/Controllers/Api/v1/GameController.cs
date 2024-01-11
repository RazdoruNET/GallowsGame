using AutoMapper;
using BLL.Interfaces;
using BLL.Models.DTO;
using GallowsGame.Requests;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("[controller]")]
public class GameController : Controller
{
    private readonly IGameService _game;
    private readonly IMapper _mapper;

    public GameController(IGameService game, IMapper mapper)
    {
        _game = game;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Get game
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<GameDto> Get(long id) => await _game.GetGame(id);

    /// <summary>
    /// Get all game
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("All")]
    public async Task<IEnumerable<GameDto>> GetAll() => await _game.GetAllGame();

    /// <summary>
    /// Post game
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<GameDto> Post([FromForm] GamePostRequest request) => await _game.CreateGame(_mapper.Map<GameDto>(request));
    
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