using System.Text.Json;
using GallowsGame.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public QuestionController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    /// <summary>
    /// Get question
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<QuestionDTO> Get()
    {
        try
        {
            return new QuestionDTO();
        }
        catch (Exception e)
        {
            _logger.LogError(JsonSerializer.Serialize<Exception>(e));
            throw;
        }
    }

    /// <summary>
    /// Post question
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<QuestionDTO> Post()
    {
        try
        {
            return new QuestionDTO();
        }
        catch (Exception e)
        {
            _logger.LogError(JsonSerializer.Serialize<Exception>(e));
            throw;
        }
    }
    
    /// <summary>
    /// Put question
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<QuestionDTO> Put()
    {
        try
        {
            return new QuestionDTO();
        }
        catch (Exception e)
        {
            _logger.LogError(JsonSerializer.Serialize<Exception>(e));
            throw;
        }
    }
    
    /// <summary>
    /// Delete question
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