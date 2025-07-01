using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class ArticleDto
{
    [Required]
    [MaxLength(250)]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    [Required]
    public int Category { get; set; } // Enum as int
} 