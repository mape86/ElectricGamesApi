namespace ElectricGamesApi.Interfaces;

interface IGame
{
    int Id { get; set; }
    string Title { get; set; }
    string Description { get; set; }
    string Platform { get; set; }
    int ReleaseYear { get; set; }
    string Genre { get; set; }
    string Publisher { get; set; }
    double Price { get; set; }
    string HeroImage { get; set; }
    string InGameImage1 { get; set; }
    string InGameImage2 { get; set; }
    string InGameImage3 { get; set; }
    string InGameImage4 { get; set; }


}