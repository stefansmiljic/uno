using Uno.Entities;

namespace Uno.Resources;

public class GameResource
{
    public int Id { get; init; }
    public string CurrentPlayerId { get; set; }
    public CurrentPlayerState CurrentPlayerState { get; set; }
    public List<Player> Players { get; set; }
    public string CurrentCard { get; set; }
    public List<string> DrawPile { get; set; }
    public List<string> DiscardPile { get; set; }
    public bool GameEnded { get; set; }
}