using System.Text.Json;
using GallowsGame.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("[controller]")]
public class QuestionController : Controller
{
    private readonly ILogger<QuestionController> _logger;

    public QuestionController(ILogger<QuestionController> logger)
    {
        _logger = logger;
    }
    
    /// <summary>
    /// Get question
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<QuestionBaseDto> Get()
    {
        try
        {
            return new QuestionBaseDto();
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
    public async Task<QuestionBaseDto> Post()
    {
        try
        {
            return new QuestionBaseDto();
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
    public async Task<QuestionBaseDto> Put()
    {
        try
        {
            return new QuestionBaseDto();
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