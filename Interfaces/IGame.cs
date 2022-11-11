namespace ElectricGamesApi.Interfaces;

interface IGame
{
    int Id { get; set; }
    string Title { get; set; }
    string Platform { get; set; }
    int ReleaseYear { get; set; }
    double Price { get; set; }
    string Image { get; set; }

}