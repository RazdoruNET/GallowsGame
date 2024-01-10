namespace GallowsGame.Models.Entity;

public class Question : BaseEntity
{
    public IEnumerable<Answer> Answers { get; set; }
}