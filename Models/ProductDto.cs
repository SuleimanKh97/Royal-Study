using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class ProductDto
{
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public int StockQuantity { get; set; }

    [MaxLength(100)]
    public string? TeacherName { get; set; }

    [MaxLength(100)]
    public string? Subject { get; set; }

    [MaxLength(100)]
    public string? EducationalStage { get; set; }

    public string? ImageUrl { get; set; }

    [Required]
    public int Status { get; set; } // Enum as int

    [Required]
    public int DeliveryType { get; set; } // Enum as int

    [Required]
    public int CategoryId { get; set; }
} 