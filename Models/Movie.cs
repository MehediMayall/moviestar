using System.ComponentModel.DataAnnotations;

namespace MovieStar.Models
{
    public class Movie : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int ReleasedDate { get; set; }
    }
}