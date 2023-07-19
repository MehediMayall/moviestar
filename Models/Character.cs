using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStar.Models
{
    public class Character : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100, MinimumLength =2)]
        public string CharacterName { get; set; } = "";
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Intelligence { get; set; }

        public ICollection<Movie>? Movies {get; set;} 
        public User? User { get; set; }
    }
}