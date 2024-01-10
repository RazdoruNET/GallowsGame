using BLL.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("[controller]")]
public class QuestionController : Controller
{
    public QuestionController()
    {

    }
    
    /// <summary>
    /// Get question
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<QuestionDTO> Get() => new QuestionDTO();

    /// <summary>
    /// Post question
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<QuestionDTO> Post() => new QuestionDTO();
            
    /// <summary>
    /// Put question
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<QuestionDTO> Put() => new QuestionDTO();
    
    /// <summary>
    /// Delete question
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public async Task<bool> Delete() => true;
}