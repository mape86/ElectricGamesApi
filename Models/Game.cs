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
    public string InGameImage1 { get; set; } = "";
    public string InGameImage2 { get; set; } = "";
    public string InGameImage3 { get; set; } = "";
    public string InGameImage4 { get; set; } = "";
}