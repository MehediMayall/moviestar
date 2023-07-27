namespace MovieStar.Models;

public class Movie : BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime ReleasedDate { get; set; }

    public int CountryID { get; set; }

    public User User { get; set; }
}
