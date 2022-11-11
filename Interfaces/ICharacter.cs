namespace ElectricGamesApi.Interfaces;

interface ICharacter
{
    int Id { get; set; }
    string Name { get; set; }
    string Gender { get; set; }
    string Game { get; set; }
    string Description { get; set; }
    string Image { get; set; }
}