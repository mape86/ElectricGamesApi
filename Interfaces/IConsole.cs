namespace ElectricGamesApi.Interfaces;

interface IConsole
{
    int Id { get; set; }
    string Brand { get; set; }
    string Model { get; set; }
    double Price { get; set; }
    string Description { get; set; }
    string Image { get; set; }

}