using System.ComponentModel.DataAnnotations.Schema;
using GallowsGame.Models.Enum;

namespace GallowsGame.Models.Entity;

public class QuestionAnswer : BaseEntity
{
    public TypeAnswerEnum TypeAnswer { get; set; }
    
    public Guid QuestionId { get; set; }

    [ForeignKey("QuestionId")]
    public Question Question { get; set; }
}