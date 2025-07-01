using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

// يمثل مقال أو نصيحة في قسم النصائح والمقالات
public class Article
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(250)]
    public string Title { get; set; } // عنوان المقال

    [Required]
    public string Content { get; set; } // النص الكامل للمقال

    public ArticleCategory Category { get; set; } // فئة المقال
}

// Enum لتحديد فئة المقال
public enum ArticleCategory
{
    TimeManagement, // تنظيم الوقت
    StudyTips,      // استذكار
    MentalHealth    // نفسية
}
