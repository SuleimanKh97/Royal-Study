using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalStudy.Models;

// يمثل السؤال الواحد التابع لكويز معين
public class Question
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Text { get; set; } // نص السؤال

    // The options will be stored as a JSON string in the database for simplicity.
    // e.g., ["Option A", "Option B", "Option C", "Option D"]
    [Required]
    public string OptionsJson { get; set; }

    [Required]
    public int CorrectAnswerIndex { get; set; } // The index (0, 1, 2, or 3) of the correct option.

    // --- Foreign Key for Quiz ---
    public int QuizId { get; set; }
    [ForeignKey("QuizId")]
    public virtual Quiz Quiz { get; set; } // Navigation property
}
