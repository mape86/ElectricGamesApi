using Microsoft.AspNetCore.Mvc;
using ElectricGamesApi.Contexts;
using ElectricGamesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricGamesApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CharacterController : ControllerBase
{
    private readonly ElectricGamesContext context;

    public CharacterController(ElectricGamesContext _context)
    {
        context = _context;
    }

    [HttpGet]
    public async Task<List<Character>> GetCharaters()
    {
        List<Character> characters = await context.Character.ToListAsync();
        return characters;
    }

}