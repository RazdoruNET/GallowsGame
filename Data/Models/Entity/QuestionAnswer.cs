using System.ComponentModel.DataAnnotations.Schema;
using GallowsGame.Models.Enum;

namespace Data.Models.Entity;

public class QuestionAnswer : BaseEntity
{
    public TypeAnswerEnum TypeAnswer { get; set; }
    
    public long QuestionId { get; set; }

    [ForeignKey("QuestionId")]
    public Question Question { get; set; }
}