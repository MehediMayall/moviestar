using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStar.Models;

public class Movie : BaseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(10)]
    public string Name { get; set; } = null!;

    [Required]
    public DateTime ReleasedDate { get; set; }
}
