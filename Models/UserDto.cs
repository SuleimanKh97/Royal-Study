using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class UserDto
{
    [Required]
    [MaxLength(100)]
    public string Username { get; set; }

    [Required]
    public string PasswordHash { get; set; }
} 