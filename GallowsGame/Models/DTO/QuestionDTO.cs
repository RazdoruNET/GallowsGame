namespace GallowsGame.Models.DTO;

public class QuestionDTO : BaseDTO
{
    public IEnumerable<QuestionAnswerDTO> Answers { get; set; }
}