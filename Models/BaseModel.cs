using System;
using System.ComponentModel.DataAnnotations;

namespace MovieStar.Models
{
    public abstract class  BaseModel
    {
        public Boolean IsActive { get; set; } = true;

        [Required]
        public string CreatedByID { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public string? UpdatedByID { get; set; }
        public DateTime UpdatedOn { get; set; } 
    }
}