using Microsoft.AspNetCore.Mvc;
using uno.Models.DTOs;

namespace uno.Services;

public interface IGameService
{
    public Task<string> JoinRoom(string roomId, string username);
    public Task<string> CreateRoom(string username, int playerCount);
    public Task<EmptyResult> LeaveRoom();
    public Task<EmptyResult> SendMove(MoveDTO move);
    public Task<EmptyResult> Rematch();
}