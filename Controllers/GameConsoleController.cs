using Microsoft.AspNetCore.Mvc;
using ElectricGamesApi.Contexts;
using ElectricGamesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricGamesApi.Controllers;

[ApiController]
[Route("api/[controller]")]

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




}