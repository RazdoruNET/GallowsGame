namespace GallowsGame.Models.Entity;

public class Question : BaseEntity
{
    public IEnumerable<QuestionAnswer> Answers { get; set; }
}