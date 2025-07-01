using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class ScheduleDto
{
    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [Required]
    public string FilePath { get; set; }

    public DateTime ActivationDate { get; set; }
} 