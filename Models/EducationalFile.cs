using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

// يمثل ملف PDF أو ملخص تعليمي قابل للتحميل
public class EducationalFile
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string FileName { get; set; } // اسم الملف

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    [MaxLength(100)]
    public string Subject { get; set; } // المادة

    [Required]
    [MaxLength(100)]
    public string EducationalLevel { get; set; } // الصف

    [Required]
    public string FilePath { get; set; } // مسار تخزين ملف الـ PDF على الخادم
}
