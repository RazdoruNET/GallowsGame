namespace Data.Models.Entity;

public class Game : BaseEntity
{
    public IEnumerable<Question> Questions { get; set; }
}