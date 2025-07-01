using System.ComponentModel.DataAnnotations;

namespace RoyalStudy.Models;

public class QuestionDto
{
    [Required]
    public string Text { get; set; }

    [Required]
    public string OptionsJson { get; set; }

    [Required]
    public int CorrectAnswerIndex { get; set; }

    [Required]
    public int QuizId { get; set; }
} 