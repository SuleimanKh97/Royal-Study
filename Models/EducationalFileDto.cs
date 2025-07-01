using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class EducationalFileDto
{
    [Required]
    [MaxLength(200)]
    public string FileName { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    [MaxLength(100)]
    public string Subject { get; set; }

    [Required]
    [MaxLength(100)]
    public string EducationalLevel { get; set; }

    [Required]
    public string FilePath { get; set; }
} 