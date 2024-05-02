using System.Security.Cryptography;
using uno.Models.DTOs;

namespace uno.Utilities;

public static class Utility
{
    private static Random _random = new Random();
    public static List<CardDTO> GetDeck()
    {
        var deck = new List<CardDTO>();
        for (int symbol = 0; symbol < 12; symbol++)
        {
            for (int color = 0; color < 4; color++)
            {
                deck.Add(new CardDTO()
                {
                    Color = (CardColor)(color),
                    Symbol = (CardSymbol)symbol
                });
            }
        }

        for (int black = 0; black < 4; black++)
        {
            deck.Add(new CardDTO()
            {
                Color = CardColor.Black,
                Symbol = CardSymbol.ChangeColor
            });
            deck.Add(new CardDTO()
            {
                Color = CardColor.Black,
                Symbol = CardSymbol.PlusFour
            });
        }

        deck = ShuffleDeck(deck);
        return deck;
    }

    public static List<CardDTO> ShuffleDeck(List<CardDTO> deck)
    {
        var shuffledDeck = deck.OrderBy(_ => _random.Next()).ToList();
        return shuffledDeck;
    }

    public static CardDTO PopCard(List<CardDTO> deck)
    {
        var card = deck[0];
        deck.RemoveAt(0);
        return card;
    }
}