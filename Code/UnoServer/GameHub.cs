using Microsoft.AspNetCore.SignalR;

namespace UnoServer
{
    public class GameHub : Hub<IGameClient>
    {
        public GameHub() { }

    }
}
