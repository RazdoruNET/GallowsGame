using GallowsGame.Models.Enum;

namespace BLL.Models.DTO;

public class QuestionAnswerDTO : BaseDTO
{
    public TypeAnswerEnum TypeAnswer { get; set; }
}