namespace uno.Models.DTOs;

public class MoveDTO
{
    public Move Move { get; set; }
}

public enum Move
{
    Card,
    Skip,
    Draw
}