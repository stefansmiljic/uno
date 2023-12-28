using System.ComponentModel.DataAnnotations;

public class GameState
{
    [Key]
    public string GameId { get; set; }
    public string CurrentPlayerId { get; set; }
    public List<PlayerState> PlayerStates { get; set; }
    public string CurrentCardInPlay { get; set; }
    public List<string> DrawPile { get; set; }
    public List<string> DiscardPile { get; set; }
    public bool GameEnded { get; set; }
}