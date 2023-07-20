using System.ComponentModel.DataAnnotations;

namespace MovieStar.Dto
{
    public class UserAddDto
    {
        [Required]
        [StringLength(50, MinimumLength =2)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(50, MinimumLength =2)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(30, MinimumLength =3)]
        public string Password { get; set; }= string.Empty;

        [Required]
        [StringLength(120, MinimumLength = 10)]
        public string Email { get; set; } = string.Empty;

    }
}