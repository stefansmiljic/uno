using JWTAuthentication.NET8._0.Auth;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class GameController : ControllerBase
{
    public ApplicationDbContext Context { get; set; }

    [HttpPost("AddGameState")]
    public async Task<ActionResult> SaveGameState([FromBody]GameState gs)
    {
        try
        {
            Context.GameStates.Add(gs);
            await Context.SaveChangesAsync();
            return Ok("Game state added.");
        }
        catch(Exception)
        {
            throw;
        }
    }

    [HttpGet("ShowGameState")]
    public ActionResult ShowGameStates()
    {
        return Ok(Context.GameStates);
    }
}