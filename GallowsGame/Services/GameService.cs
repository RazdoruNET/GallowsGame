using GallowsGame.Interfaces;
using GallowsGame.Models.DTO;
using GallowsGame.Models.Entity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;


namespace GallowsGame.Services;

public class GameService : IGameService
{
    private readonly AppDbContext _appDbContext;
    private readonly IMapper _mapper;
    public GameService(AppDbContext appDbContext, IMapper mapper)
    {
        _appDbContext = appDbContext;
        _mapper = mapper;
    }
    
    public async Task<GameDto> GetGame(Guid? id)
    {
        return _mapper.Map<GameDto>(
            await _appDbContext.Games
                .AsNoTracking()
                .Where(x => (id.HasValue) ? x.Id == id.Value : true)
                .FirstOrDefaultAsync()
            );
    }
}