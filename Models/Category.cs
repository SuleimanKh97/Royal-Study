using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

// يمثل تصنيف المنتجات (كتب، دوسيات، إلخ)
public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    // This defines the one-to-many relationship with Products
    public virtual ICollection<Product> Products { get; set; }
}
