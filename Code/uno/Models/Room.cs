using uno.Models.DTOs;
using uno.Utilities;
namespace uno.Models;

public class Room
{
    private int MaxPlayers { get; set; }
    private string? RoomId { get; set; }
    private GameStateDTO GameState { get; set; }

    public Room(string roomId, int maxPlayers)
    {
        RoomId = roomId;
        MaxPlayers = maxPlayers;
        GameState = new();
        GameState.Deck = Utility.GetDeck();
    }
    
    //udji u igru
    public void AddPlayerToRoom(PlayerDTO player)
    {
        lock (GameState.Players!)
        {
            GameState.Players.Add(player);
        }
    }
    //izadji iz igre
    public void RemovePlayerFromRoom(PlayerDTO player)
    {
        lock (GameState.Players!)
        {
            GameState.Players.Remove(player);
        }
    }
    //startuj igru
    public void StartGame()
    {
        GameState.Started = true;
    }
    //rematch
    public void Rematch()
    {
        this.StartGame();
    }
    //ko sledeci igra
    
    //vuci kartu
    public void DrawCard(PlayerDTO player)
    {
        lock (GameState.Deck!)
        {
            var card = Utility.PopCard(GameState.Deck);
            lock (player.MyCards!)
            {
                player.MyCards.Add(card);
            }
            player.CardCount++;
        }
    }
    //odigraj kartu
    public void PlayCard(PlayerDTO player, CardDTO card)
    {
        GameState.TopCard = card;
        lock (player.MyCards)
        {
            player.MyCards.Remove(card);
        }
    }
    //okreni smer
    //
}