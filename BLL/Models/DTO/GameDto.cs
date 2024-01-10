namespace BLL.Models.DTO;

public class GameDto : BaseDTO
{
    public IEnumerable<QuestionDTO> Questions { get; set; }
}