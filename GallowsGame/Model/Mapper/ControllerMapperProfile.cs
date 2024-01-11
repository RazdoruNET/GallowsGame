using AutoMapper;
using BLL.Models.DTO;
using GallowsGame.Requests;

namespace GallowsGame.Models.Mapper;

public class ControllerMapperProfile : Profile
{
    public ControllerMapperProfile()
    {
        CreateMap<GamePostRequest, GameDto>().ReverseMap();
    }
}