using AutoMapper;
using Uno.Entities;
using Uno.Resources;

namespace Uno.Mapper;

public class PlayerProfile : Profile
{
    public PlayerProfile()
    {
        CreateMap<Player, PlayerResource>()
            .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
            .ForMember(t => t.Hand, o => o.MapFrom(t => t.Hand))
            .ReverseMap();

    }
}