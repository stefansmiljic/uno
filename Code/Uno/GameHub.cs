using Microsoft.AspNetCore.SignalR;

namespace Uno;

public class GameHub : Hub
{
    private static readonly Dictionary<string, string> Players = new();
    public async Task Send(string message)
    {
        Console.WriteLine("Message received: " + message);
        await Clients.All.SendAsync("Send", message);
    }

    public async Task CreateGame()
    {
        var gameId = Guid.NewGuid().ToString().Substring(0, 8);
        await Groups.AddToGroupAsync(Context.ConnectionId, gameId);
        Players.Add(Context.ConnectionId, gameId);
        await Clients.Caller.SendAsync("JoinedGame", gameId);
    }

    public async Task JoinGame(string gameId)
    {
        await Clients.Group(gameId).SendAsync("PlayerJoined", Context.ConnectionId);
        await Groups.AddToGroupAsync(Context.ConnectionId, gameId);
        Players.Add(Context.ConnectionId, gameId);
        await Clients.Caller.SendAsync("JoinedGame", gameId);
    }

    public async Task StartGame()
    {
        var gameId = Players[Context.ConnectionId];
        await Clients.Group(gameId).SendAsync("NextGame", "Uno");
    }

    public async Task LeaveGame()
    {
        var gameId = Players[Context.ConnectionId];
        Players.Remove(Context.ConnectionId);
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, gameId);
        await Clients.Group(gameId).SendAsync("LeftGame", gameId);
    }

    public async Task SendAnswer(string answer)
    {
        var gameId = Players[Context.ConnectionId];
        await Clients.GroupExcept(gameId, Context.ConnectionId).SendAsync("ShowAnswer", answer);
    }

    //consolewriteline
    // Context.ConnectionId
}