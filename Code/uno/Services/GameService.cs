using Microsoft.AspNetCore.Mvc;
using uno.Models;
using uno.Models.DTOs;

namespace uno.Services;

public class GameService : IGameService
{
    private Dictionary<string, Room> Rooms { get; set; } = new();
    private Dictionary<string, string> PlayerToRoomMap { get; set; } = new();
    
    public Task<string> JoinRoom(string roomId, string username)
    {
        return Task.FromResult("");
    }

    public Task<string> CreateRoom(string username, int playerCount=2)
    {
        var newId = Guid.NewGuid();
        Rooms.Add(newId.ToString(), new Room(newId.ToString(), playerCount));
        return Task.FromResult("");
    }

    public Task<EmptyResult> LeaveRoom()
    {
        throw new NotImplementedException();
    }

    public Task<EmptyResult> SendMove(MoveDTO move)
    {
        throw new NotImplementedException();
    }

    public Task<EmptyResult> Rematch()
    {
        throw new NotImplementedException();
    }
}