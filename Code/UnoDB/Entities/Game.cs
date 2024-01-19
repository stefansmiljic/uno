using System.ComponentModel.DataAnnotations;

namespace Uno.Entities;

public record Game : IEntity
{
    public string CurrentPlayerId { get; set; }
    public CurrentPlayerState CurrentPlayerState { get; set; }
    public List<Player> Players { get; set; }
    public string CurrentCard { get; set; }
    public List<string> DrawPile { get; set; }
    public List<string> DiscardPile { get; set; }
    public bool GameEnded { get; set; }
}

public enum CurrentPlayerState
{
    StartedPlaying,
    MustDraw,
    HasPlayable,
    MustSkip
}