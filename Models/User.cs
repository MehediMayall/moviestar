using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStar.Models
{
    public class User: BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength =3)]
        public string Username { get; set; } = string.Empty;
        [Required]
        [StringLength(120, MinimumLength =10)]
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];

        public List<Character>? Characters { get; set; }
    }
}