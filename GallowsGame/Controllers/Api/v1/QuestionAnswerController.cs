using BLL.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Controllers.Api.v1;

[ApiController]
[Route("Question/Answer")]
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
    [Route("{id}")]
    public async Task<QuestionAnswerDTO> Get(long id) => new QuestionAnswerDTO();
   
    /// <summary>
    /// Post question
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<QuestionAnswerDTO> Post(QuestionAnswerDTO data) => new QuestionAnswerDTO();
    
    /// <summary>
    /// Put question
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<QuestionAnswerDTO> Put(QuestionAnswerDTO data) => new QuestionAnswerDTO();
    
    /// <summary>
    /// Delete question
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    [Route("/Question/Answer/{id}")]
    public async Task<bool> Delete(long id) => true;
}