using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Models.DTO;

namespace BLL.Interfaces;

public interface IGameService
{
     Task<GameDto> GetGame(long id);

     Task<IEnumerable<GameDto>> GetAllGame();
}