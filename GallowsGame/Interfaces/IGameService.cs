using GallowsGame.Models.DTO;

namespace GallowsGame.Interfaces;

public interface IGameService
{
     Task<GameDto> GetGame(Guid? id);

     Task<IEnumerable<GameDto>> GetAllGame();
}