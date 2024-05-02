namespace uno.Models.DTOs;

public class PlayerDTO
{
    public required string Username { get; set; }
    public List<CardDTO>? MyCards { get; set; }
    public int CardCount { get; set; }
}