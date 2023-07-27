namespace MovieStar.Models;

public class Character : BaseModel
{
    public int Id { get; set; }
    public string CharacterName { get; set; } = "";
    // public int CountryId { get; set; }
    public int HitPoints { get; set; }
    public int Strength { get; set; }
    public int Defense { get; set; }
    public int Intelligence { get; set; }
    // public ICollection<Movie>? Movies {get; set;} 
    public User? User { get; set; }
}
