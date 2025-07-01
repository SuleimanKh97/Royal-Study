using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

// يمثل المستخدم الذي يمكنه الدخول إلى لوحة التحكم (Admin)
public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Username { get; set; }

    [Required]
    public string PasswordHash { get; set; } // The password will be stored as a secure hash, not plain text.
}
