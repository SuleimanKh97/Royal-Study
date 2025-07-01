using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class QuizDto
{
    [Required]
    [MaxLength(250)]
    public string Title { get; set; }

    [Required]
    [MaxLength(100)]
    public string Subject { get; set; }

    [MaxLength(100)]
    public string? Chapter { get; set; }

    [Required]
    [MaxLength(100)]
    public string EducationalLevel { get; set; }

    public bool IsActive { get; set; }
} 