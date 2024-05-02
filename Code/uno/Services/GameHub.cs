using Microsoft.AspNetCore.SignalR;
using SignalRSwaggerGen.Attributes;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Internal;
using uno.Models.DTOs;

namespace uno.Services;

[SignalRHub]
public class GameHub : Hub<IUnoClient>
{
    public async Task CreateRoom(int playerCount, string username)
    {
        
    }

    public async Task JoinRoom(string roomId, string username)
    {
        
    }

    public async Task SendMove(MoveDTO move)
    {
        
    }

    public async Task LeaveRoom()
    {
        
    }

    public async Task Rematch()
    {
        
    }
}