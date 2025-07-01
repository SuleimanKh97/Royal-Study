using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalStudy.Models;

// يمثل هذا الموديل المنتج الواحد في قاعدة البيانات (دوسية، كتاب، قرطاسية، إلخ)
public class Product
{
    [Key] // This marks the property as the primary key.
    public int Id { get; set; }

    [Required(ErrorMessage = "اسم المنتج مطلوب")]
    [MaxLength(200)]
    public string Name { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; } // الوصف الإضافي

    [Required(ErrorMessage = "سعر المنتج مطلوب")]
    [Column(TypeName = "decimal(18, 2)")] // Defines the data type in the database for currency.
    public decimal Price { get; set; }

    [Required]
    public int StockQuantity { get; set; } // الكمية في المستودع

    [MaxLength(100)]
    public string? TeacherName { get; set; } // اسم الأستاذ (خاص بالدوسيات والكورسات)

    [MaxLength(100)]
    public string? Subject { get; set; } // المادة

    [MaxLength(100)]
    public string? EducationalStage { get; set; } // المرحلة (توجيهي، أول ثانوي)

    public string? ImageUrl { get; set; } // رابط صورة المنتج

    // --- Enums for fixed choices ---
    public ProductStatus Status { get; set; } // حالة المنتج (متوفر / غير متوفر)
    public DeliveryType DeliveryType { get; set; } // نوع التوصيل

    // --- Foreign Key for Category ---
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public virtual Category Category { get; set; } // Navigation property to the Category
}

// Enum لتحديد حالة المنتج
public enum ProductStatus
{
    Available,  // متوفر
    Unavailable // غير متوفر
}

// Enum لتحديد نوع التوصيل
public enum DeliveryType
{
    Delivery, // توصيل
    Pickup    // حضور للمكتبة
}
