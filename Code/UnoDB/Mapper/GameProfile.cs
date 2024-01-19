using AutoMapper;
using Uno.Entities;
using Uno.Resources;

namespace Uno.Mapper;

public class GameProfile : Profile
{
    public GameProfile()
    {
        CreateMap<Game, GameResource>()
            .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
            .ForMember(t => t.CurrentPlayerId, o => o.MapFrom(t => t.CurrentPlayerId))
            .ForMember(t => t.CurrentPlayerState, o => o.MapFrom(t => t.CurrentPlayerState))
            .ForMember(t => t.Players, o => o.MapFrom(t => t.Players))
            .ForMember(t => t.CurrentCard, o => o.MapFrom(t => t.CurrentCard))
            .ForMember(t => t.DrawPile, o => o.MapFrom(t => t.DrawPile))
            .ForMember(t => t.DiscardPile, o => o.MapFrom(t => t.DiscardPile))
            .ForMember(t => t.GameEnded, o => o.MapFrom(t => t.GameEnded))
            .ReverseMap();
    }
}