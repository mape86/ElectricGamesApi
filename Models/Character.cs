using ElectricGamesApi.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ElectricGamesApi.Models;

public class Character : ICharacter
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Gender { get; set; } = "";
    public string Game { get; set; } = "";
    public string Description { get; set; } = "";
    public string Image { get; set; } = "characterAvatar.jpg";
}