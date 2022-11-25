using Microsoft.AspNetCore.Mvc;
using ElectricGamesApi.Contexts;
using ElectricGamesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricGamesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class GameConsoleController : ControllerBase
{
    private readonly ElectricGamesContext context;

    public GameConsoleController(ElectricGamesContext _context)
    {
        context = _context;
    }

    [HttpGet]
    public async Task<List<GameConsole>> GetConsoles()
    {
        List<GameConsole> gameConsoles = await context.GameConsole.ToListAsync();
        return gameConsoles;
    }

    [HttpGet]
    [Route("[action]/{brand}")]
    public async Task<ActionResult<List<Character>>> GetConsoleByBrand(string brand)
    {

        List<GameConsole> consoles = await context.GameConsole.Where(gameConsole => gameConsole.Brand == brand).ToListAsync();

        if (consoles != null)
        {
            return Ok(consoles);
        }
        else
        {
            return NotFound();
        }
    }



}