using AutoMapper;
using GallowsGame.Models.DTO;
using GallowsGame.Models.Entity;

namespace GallowsGame.Models.Mapper;

public class DTOMapperProfile : Profile
{
    public DTOMapperProfile()
    {
        CreateMap<Game, GameDto>().ReverseMap();
        CreateMap<Question, QuestionDTO>().ReverseMap();
        CreateMap<QuestionAnswer, QuestionAnswerDTO>().ReverseMap();
    }
}