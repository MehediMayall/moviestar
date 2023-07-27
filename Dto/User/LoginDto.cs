using System.ComponentModel.DataAnnotations;

namespace MovieStar.Dto;
public class LoginDto
{
    [Required]
    [StringLength(120, MinimumLength = 10)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(30, MinimumLength =3)]
    public string Password { get; set; }= string.Empty;

}
