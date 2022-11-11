using ElectricGamesApi.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ElectricGamesApi.Models;

public class Console : IConsole
{
    [Key]
    public int Id { get; set; }
    public string Brand { get; set; } = "";
    public string Model { get; set; } = "";
    public double Price { get; set; }
    public string Description { get; set; } = "";
    public string Image { get; set; } = "consoleAvatar.jpg";
}