namespace uno.Models.DTOs;

public class CardDTO
{
    public CardColor Color { get; set; }
    public CardSymbol Symbol { get; set; }
}

public enum CardColor
{
    Red,
    Green,
    Blue,
    Yellow,
    Black
}

public enum CardSymbol
{
    Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine,
    Reverse, Skip, PlusTwo, PlusFour, ChangeColor
}