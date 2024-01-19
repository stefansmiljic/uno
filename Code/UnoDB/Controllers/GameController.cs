using Microsoft.AspNetCore.Mvc;
using Uno.Persistence;

namespace Uno.Controllers;

[ApiController]
[Route("api/GameController")]
public class GameController : ControllerBase
{
    public MainDbContext Context { get; set; }

    public GameController(MainDbContext context)
    {
        Context = context;
    }
}