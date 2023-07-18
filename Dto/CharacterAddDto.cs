using System.ComponentModel.DataAnnotations;

namespace MovieStar.Dto
{
    public class CharacterAddDto
    {
        public string CharacterName { get; set; } = "";
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Intelligence { get; set; }
        [Required]
        public string CreatedByID { get; set; }
    }
}