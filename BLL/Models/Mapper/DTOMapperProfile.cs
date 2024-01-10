using AutoMapper;
using BLL.Models.DTO;
using Data.Models.Entity;

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