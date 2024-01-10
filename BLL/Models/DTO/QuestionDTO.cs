using System.Collections.Generic;

namespace BLL.Models.DTO;

public class QuestionDTO : BaseDTO
{
    public IEnumerable<QuestionAnswerDTO> Answers { get; set; }
}