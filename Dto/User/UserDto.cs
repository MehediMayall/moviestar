using System.ComponentModel.DataAnnotations;

namespace MovieStar.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }= string.Empty;
        public string CreatedByID { get; set; }= string.Empty;
        public DateTime CreatedOn { get; set; }
    }
}