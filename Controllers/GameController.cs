using Microsoft.AspNetCore.Mvc;
using ElectricGamesApi.Contexts;
using ElectricGamesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricGamesApi.Controllers;

[ApiController]
[Route("[controller]")]

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

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> Get(int id)
    {
        Game? game = await context.Game.FindAsync(id);
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
    public async Task<ActionResult<List<Game>>> GetGameByPlatform(string platform)
    {

        List<Game> games = await context.Game.Where(game => game.Platform == platform).ToListAsync();

        if (games != null)
        {
            return Ok(games);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet]
    [Route("[action]/{genre}")]
    public async Task<ActionResult<List<Game>>> GetGameByGenre(string genre)
    {

        List<Game> games = await context.Game.Where(game => game.Genre == genre).ToListAsync();

        if (games != null)
        {
            return Ok(games);
        }
        else
        {
            return NotFound();
        }
    }

}





