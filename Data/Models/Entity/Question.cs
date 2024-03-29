using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Entity;

public class Question : BaseEntity
{
    public long GameId { get; set; }

    [ForeignKey("GameId")]
    public Game Game { get; set; }
    
    public IEnumerable<QuestionAnswer> Answers { get; set; }
}