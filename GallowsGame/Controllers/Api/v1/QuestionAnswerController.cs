using System.Text.Json;
using GallowsGame.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("Question/{Id}/Answer")]
public class QuestionAnswerController : Controller
{
    private readonly ILogger<QuestionAnswerController> _logger;

    public QuestionAnswerController(ILogger<QuestionAnswerController> logger)
    {
        _logger = logger;
    }
    
    /// <summary>
    /// Get question
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<QuestionAnswerDTO> Get()
    {
        try
        {
            return new QuestionAnswerDTO();
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
    public async Task<QuestionAnswerDTO> Post()
    {
        try
        {
            return new QuestionAnswerDTO();
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
    public async Task<QuestionAnswerDTO> Put()
    {
        try
        {
            return new QuestionAnswerDTO();
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