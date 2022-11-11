using ElectricGamesApi.Interfaces;

namespace ElectricGamesApi.Models;

public class Game : IGame
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Platform { get; set; } = "";
    public int ReleaseYear { get; set; }
    public double Price { get; set; }
    public string Image { get; set; } = "gameAvatar.jpg";
}