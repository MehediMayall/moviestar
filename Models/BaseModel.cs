using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MovieStar.Models;

public abstract class  BaseModel
{
    public Boolean IsActive { get; set; } = true;

    [Required]
    [StringLength(10, MinimumLength =2)]
    public int CreatedByID { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    [StringLength(10)]
    public int? UpdatedByID { get; set; }

    [AllowNull]
    public DateTime UpdatedOn { get; set; } 
}
