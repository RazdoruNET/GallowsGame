using System.ComponentModel.DataAnnotations.Schema;

namespace GallowsGame.Models.Entity;

public class Question : BaseEntity
{
    public Guid GameId { get; set; }

    [ForeignKey("GameId")]
    public Game Game { get; set; }
    
    public IEnumerable<QuestionAnswer> Answers { get; set; }
}