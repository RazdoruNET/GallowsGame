using GallowsGame.Interfaces;
using GallowsGame.Models.DTO;
using GallowsGame.Models.Entity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;


namespace GallowsGame.Services;

public class GameService : IGameService
{
    private readonly IMapper _mapper;
    private readonly IBaseRepositorie<Game> _repositorie;
    public GameService(IMapper mapper, IBaseRepositorie<Game> repositorie)
    {
        _mapper = mapper;
        _repositorie = repositorie;
    }
    
    public async Task<GameDto> GetGame(long id)
    {
        var result = await _repositorie.GetById(id);

        return _mapper.Map<GameDto>(result);
    }
    
    public async Task<IEnumerable<GameDto>> GetAllGame()
    {
        var result = await _repositorie.GetAll();
        
        return _mapper.Map<IEnumerable<GameDto>>(result);
    }
}