using Microsoft.AspNetCore.Mvc;
using ElectricGamesApi.Contexts;
using ElectricGamesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricGamesApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class GameController : ControllerBase
{
    private readonly ElectricGamesContext context;

    public GameController(ElectricGamesContext _context)
    {
        context = _context;
    }

    [HttpGet]
    public async Task<List<Game>> GetGames()
    {
        List<Game> games = await context.Game.ToListAsync();
        return games;
    }

    [HttpGet]
    [Route("[action]/{title}")]
    public async Task<ActionResult<Character>> GetGameByTitle(string title)
    {
        Game? game = await context.Game.FindAsync(title);
        if (game != null)
        {
            return Ok(game);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet]
    [Route("[action]/{platform}")]
    public async Task<ActionResult<Character>> GetGameByPlatform(string platform)
    {
        Game? game = await context.Game.FindAsync(platform);
        if (game != null)
        {
            return Ok(game);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet]
    [Route("[action]/{genre}")]
    public async Task<ActionResult<Character>> GetGameByGenre(string genre)
    {
        Game? game = await context.Game.FindAsync(genre);
        if (game != null)
        {
            return Ok(game);
        }
        else
        {
            return NotFound();
        }
    }

}





