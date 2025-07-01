using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

// يمثل الكويز الواحد في قسم "كويزاتك"
public class Quiz
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(250)]
    public string Title { get; set; } // اسم الكويز

    [Required]
    [MaxLength(100)]
    public string Subject { get; set; } // المادة

    [MaxLength(100)]
    public string? Chapter { get; set; } // الفصل

    [Required]
    [MaxLength(100)]
    public string EducationalLevel { get; set; } // الصف (توجيهي علمي / أدبي)

    public bool IsActive { get; set; } // لتفعيل أو إخفاء الكويز

    // One-to-many relationship with Questions
    public virtual ICollection<Question> Questions { get; set; }
}
