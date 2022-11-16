using ElectricGamesApi.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ElectricGamesApi.Models;

public class Game : IGame
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Platform { get; set; } = "";
    public int ReleaseYear { get; set; }
    public string Publisher { get; set; } = "Electric Games";
    public string Genre { get; set; } = "";
    public double Price { get; set; }
    public string HeroImage { get; set; } = "gameAvatar.jpg";

}