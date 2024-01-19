namespace UnoServer
{
    public interface IGameClient
    {
        Task CreateRoom();
        Task JoinRoom(string roomId);
        Task LeaveRoom(string roomId);
        Task StartGame(string roomId);
        Task SendGameMessage(string message, string roomId);
    }
}
