using GallowsGame.Models.DTO;

namespace GallowsGame.Interfaces;

public interface IGameService
{
     Task<GameDto> GetGame(long id);

     Task<IEnumerable<GameDto>> GetAllGame();
}