#nullable disable
using Microsoft.EntityFrameworkCore;

namespace ElectricGamesApi.Contexts;

public class ElectricGamesContext : DbContext
{
    public ElectricGamesContext(DbContextOptions<ElectricGamesContext> options) : base(options) { }

    public DbSet<ElectricGamesApi.Models.Character> Character { get; set; }
    public DbSet<ElectricGamesApi.Models.GameConsole> GameConsole { get; set; }
    public DbSet<ElectricGamesApi.Models.Game> Game { get; set; }


}