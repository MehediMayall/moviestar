using System;
using System.ComponentModel.DataAnnotations;

namespace MovieStar.Models
{
    public abstract class  BaseModel
    {
        public Boolean IsActive { get; set; } = true;

        [Required]
        [StringLength(10, MinimumLength =2)]
        public string CreatedByID { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [StringLength(10)]
        public string? UpdatedByID { get; set; }
        public DateTime UpdatedOn { get; set; } 
    }
}