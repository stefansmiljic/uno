using uno.Models.DTOs;

namespace uno.Services;

public interface IUnoClient
{
    Task SendState(GameStateDTO gameState);
    Task ShowWinner(string winner);
}