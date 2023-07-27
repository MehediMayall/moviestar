namespace MovieStar.Dto;

public class CharacterDto
{
    public int Id { get; set; }
    public string CharacterName { get; set; } = "";
    public int HitPoints { get; set; }
    public int Strength { get; set; }
    public int Defense { get; set; }
    public int Intelligence { get; set; }
    public string? CreatedByID { get; set; }

}
