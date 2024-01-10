using System.Text.Json;
using GallowsGame.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("[controller]")]
public class GameController : Controller
{
    private readonly ILogger<GameController> _logger;

    public GameController(ILogger<GameController> logger)
    {
        _logger = logger;
    }
    
    /// <summary>
    /// Get game
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<GameDTO> Get()
    {
        try
        {
            return new GameDTO();
        }
        catch (Exception e)
        {
            _logger.LogError(JsonSerializer.Serialize<Exception>(e));
            throw;
        }
    }

    /// <summary>
    /// Post game
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<GameDTO> Post()
    {
        try
        {
            return new GameDTO();
        }
        catch (Exception e)
        {
            _logger.LogError(JsonSerializer.Serialize<Exception>(e));
            throw;
        }
    }
    
    /// <summary>
    /// Put game
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<GameDTO> Put()
    {
        try
        {
            return new GameDTO();
        }
        catch (Exception e)
        {
            _logger.LogError(JsonSerializer.Serialize<Exception>(e));
            throw;
        }
    }
    
    /// <summary>
    /// Delete game
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public async Task<bool> Delete()
    {
        try
        {
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(JsonSerializer.Serialize<Exception>(e));
            throw;
        }
    }
}