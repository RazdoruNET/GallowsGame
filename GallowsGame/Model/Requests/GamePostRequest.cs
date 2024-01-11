using BLL.Models.DTO;

namespace GallowsGame.Requests;

public class GamePostRequest
{
    public string Name { get; set; }
    public IDictionary<string,IDictionary<string, bool>> Questions { get; set; }
}