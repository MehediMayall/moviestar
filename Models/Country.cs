namespace MovieStar.Models;

public class Country: BaseModel
{
    public int Id { get; set; } 
    public string CountryName { get; set; } = string.Empty;

    public List<Movie> Movies { get; set; }
}