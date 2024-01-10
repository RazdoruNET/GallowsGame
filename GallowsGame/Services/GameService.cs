using GallowsGame.Interfaces;
using GallowsGame.Models.DTO;
using GallowsGame.Models.Entity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;


namespace GallowsGame.Services;

public class GameService : IGameService
{
    private readonly IMapper _mapper;
    public GameService(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public async Task<GameDto> GetGame(Guid? id)
    {
        var result = new object();

        return _mapper.Map<GameDto>(result);
    }
}