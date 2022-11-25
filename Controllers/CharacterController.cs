using Microsoft.AspNetCore.Mvc;
using ElectricGamesApi.Contexts;
using ElectricGamesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricGamesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class CharacterController : ControllerBase
{
    private readonly ElectricGamesContext context;

    public CharacterController(ElectricGamesContext _context)
    {
        context = _context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Character>>> GetCharaters()
    {
        List<Character> characters = await context.Character.ToListAsync();
        return characters;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetCharacterById(int id)
    {
        Character? character = await context.Character.FindAsync(id);
        if (character != null)
        {
            return Ok(character);
        }
        else
        {
            return NotFound();
        }
    }


    [HttpPost]
    public async Task<ActionResult<Character>> Post(Character newCharacter)
    {
        try
        {

            context.Character.Add(newCharacter);
            await context.SaveChangesAsync();
            return CreatedAtAction("Post", new { id = newCharacter.Id }, newCharacter);
        }
        catch
        {
            return StatusCode(500);
        }

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        Character? character = await context.Character.FindAsync(id);
        if (character != null)
        {
            context.Character.Remove(character);
            await context.SaveChangesAsync();
        }

        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Put(Character editedCharacter)
    {
        context.Entry(editedCharacter).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return NoContent();
    }


}