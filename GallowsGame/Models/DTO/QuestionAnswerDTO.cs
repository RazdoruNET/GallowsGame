using GallowsGame.Models.Enum;

namespace GallowsGame.Models.DTO;

public class QuestionAnswerDTO : BaseDTO
{
    public TypeAnswerEnum TypeAnswer { get; set; }

    public QuestionDTO Question { get; set; }
}