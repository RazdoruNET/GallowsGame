using GallowsGame.Interfaces;
using GallowsGame.Models.DTO;

namespace GallowsGame.Services;

public class GameService : IGameService
{
    public Task<GameDto> GetGame(Guid? id)
    {
        throw new NotImplementedException();
    }
}