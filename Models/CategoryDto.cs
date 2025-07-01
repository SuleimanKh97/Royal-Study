using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class CategoryDto
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
} 