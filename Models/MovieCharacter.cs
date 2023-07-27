namespace MovieStar.Models;

public class MovieCharacter: BaseModel
{
    public int Id { get; set; } 
    public int MovieID { get; set; } = 0;
    public int CharacterID { get; set; }
}