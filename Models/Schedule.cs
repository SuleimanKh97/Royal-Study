using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

// يمثل جدول أو رزنامة قابلة للتحميل
public class Schedule
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } // عنوان الجدول

    [Required]
    public string FilePath { get; set; } // مسار تخزين الصورة أو ملف الـ PDF

    public DateTime ActivationDate { get; set; } // تاريخ تفعيل الجدول ليظهر للطلاب
}
