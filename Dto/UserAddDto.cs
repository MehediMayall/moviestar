using System.ComponentModel.DataAnnotations;

namespace MovieStar.Dto
{
    public class UserAddDto
    {
        [Required]
        [StringLength(20, MinimumLength =3)]
        public string Username { get; set; }= string.Empty;

        [Required]
        [StringLength(30, MinimumLength =3)]
        public string Password { get; set; }= string.Empty;
    }
}