namespace uno.Models.DTOs;

public class GameStateDTO
{
    public List<PlayerDTO>? Players { get; set; }
    
    public CardDTO? TopCard { get; set; }
    public string? WhoseTurn { get; set; }
    public List<CardDTO>? Deck { get; set; }
    public bool Started { get; set; }
    public bool CanDraw { get; set; }
    public bool DirectionClockwise { get; set; }
}