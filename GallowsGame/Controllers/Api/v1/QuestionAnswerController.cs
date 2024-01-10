using System.Text.Json;
using GallowsGame.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("Question/{Id}/Answer")]
public class QuestionAnswerController : Controller
{
    public QuestionAnswerController()
    {
    }
    
    /// <summary>
    /// Get question
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<QuestionAnswerDTO> Get() => new QuestionAnswerDTO();
   
    /// <summary>
    /// Post question
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<QuestionAnswerDTO> Post() => new QuestionAnswerDTO();
    
    /// <summary>
    /// Put question
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<QuestionAnswerDTO> Put() => new QuestionAnswerDTO();
    
    /// <summary>
    /// Delete question
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public async Task<bool> Delete() => true;
}