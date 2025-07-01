using Microsoft.AspNetCore.Mvc;
using RoyalStudy.Data;
using RoyalStudy.Models;

namespace RoyalStudy.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AdminController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    // --- PRODUCTS ---
    [HttpGet("products")]
    public IActionResult GetAllProducts() => Ok(_context.Products.ToList());

    [HttpGet("products/{id}")]
    public IActionResult GetProduct(int id)
    {
        var item = _context.Products.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("products")]
    public IActionResult CreateProduct([FromBody] ProductDto dto)
    {
        var product = new Product
        {
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            StockQuantity = dto.StockQuantity,
            TeacherName = dto.TeacherName,
            Subject = dto.Subject,
            EducationalStage = dto.EducationalStage,
            ImageUrl = dto.ImageUrl,
            Status = (ProductStatus)dto.Status,
            DeliveryType = (DeliveryType)dto.DeliveryType,
            CategoryId = dto.CategoryId
        };
        _context.Products.Add(product);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    [HttpPut("products/{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] ProductDto dto)
    {
        var product = _context.Products.Find(id);
        if (product == null) return NotFound();
        product.Name = dto.Name;
        product.Description = dto.Description;
        product.Price = dto.Price;
        product.StockQuantity = dto.StockQuantity;
        product.TeacherName = dto.TeacherName;
        product.Subject = dto.Subject;
        product.EducationalStage = dto.EducationalStage;
        product.ImageUrl = dto.ImageUrl;
        product.Status = (ProductStatus)dto.Status;
        product.DeliveryType = (DeliveryType)dto.DeliveryType;
        product.CategoryId = dto.CategoryId;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("products/{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var item = _context.Products.Find(id);
        if (item == null) return NotFound();
        _context.Products.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }

    // --- CATEGORIES ---
    [HttpGet("categories")]
    public IActionResult GetAllCategories() => Ok(_context.Categories.ToList());

    [HttpGet("categories/{id}")]
    public IActionResult GetCategory(int id)
    {
        var item = _context.Categories.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("categories")]
    public IActionResult CreateCategory([FromBody] CategoryDto dto)
    {
        var category = new Category { Name = dto.Name };
        _context.Categories.Add(category);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
    }

    [HttpPut("categories/{id}")]
    public IActionResult UpdateCategory(int id, [FromBody] CategoryDto dto)
    {
        var category = _context.Categories.Find(id);
        if (category == null) return NotFound();
        category.Name = dto.Name;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("categories/{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var item = _context.Categories.Find(id);
        if (item == null) return NotFound();
        _context.Categories.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }

    // --- QUIZZES ---
    [HttpGet("quizzes")]
    public IActionResult GetAllQuizzes() => Ok(_context.Quizzes.ToList());

    [HttpGet("quizzes/{id}")]
    public IActionResult GetQuiz(int id)
    {
        var item = _context.Quizzes.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("quizzes")]
    public IActionResult CreateQuiz([FromBody] QuizDto dto)
    {
        var quiz = new Quiz
        {
            Title = dto.Title,
            Subject = dto.Subject,
            Chapter = dto.Chapter,
            EducationalLevel = dto.EducationalLevel,
            IsActive = dto.IsActive
        };
        _context.Quizzes.Add(quiz);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetQuiz), new { id = quiz.Id }, quiz);
    }

    [HttpPut("quizzes/{id}")]
    public IActionResult UpdateQuiz(int id, [FromBody] QuizDto dto)
    {
        var quiz = _context.Quizzes.Find(id);
        if (quiz == null) return NotFound();
        quiz.Title = dto.Title;
        quiz.Subject = dto.Subject;
        quiz.Chapter = dto.Chapter;
        quiz.EducationalLevel = dto.EducationalLevel;
        quiz.IsActive = dto.IsActive;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("quizzes/{id}")]
    public IActionResult DeleteQuiz(int id)
    {
        var item = _context.Quizzes.Find(id);
        if (item == null) return NotFound();
        _context.Quizzes.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }

    // --- QUESTIONS ---
    [HttpGet("questions")]
    public IActionResult GetAllQuestions() => Ok(_context.Questions.ToList());

    [HttpGet("questions/{id}")]
    public IActionResult GetQuestion(int id)
    {
        var item = _context.Questions.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("questions")]
    public IActionResult CreateQuestion([FromBody] QuestionDto dto)
    {
        var question = new Question
        {
            Text = dto.Text,
            OptionsJson = dto.OptionsJson,
            CorrectAnswerIndex = dto.CorrectAnswerIndex,
            QuizId = dto.QuizId
        };
        _context.Questions.Add(question);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetQuestion), new { id = question.Id }, question);
    }

    [HttpPut("questions/{id}")]
    public IActionResult UpdateQuestion(int id, [FromBody] QuestionDto dto)
    {
        var question = _context.Questions.Find(id);
        if (question == null) return NotFound();
        question.Text = dto.Text;
        question.OptionsJson = dto.OptionsJson;
        question.CorrectAnswerIndex = dto.CorrectAnswerIndex;
        question.QuizId = dto.QuizId;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("questions/{id}")]
    public IActionResult DeleteQuestion(int id)
    {
        var item = _context.Questions.Find(id);
        if (item == null) return NotFound();
        _context.Questions.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }

    // --- EDUCATIONAL FILES ---
    [HttpGet("educationalfiles")]
    public IActionResult GetAllEducationalFiles() => Ok(_context.EducationalFiles.ToList());

    [HttpGet("educationalfiles/{id}")]
    public IActionResult GetEducationalFile(int id)
    {
        var item = _context.EducationalFiles.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("educationalfiles")]
    public IActionResult CreateEducationalFile([FromBody] EducationalFileDto dto)
    {
        var file = new EducationalFile
        {
            FileName = dto.FileName,
            Description = dto.Description,
            Subject = dto.Subject,
            EducationalLevel = dto.EducationalLevel,
            FilePath = dto.FilePath
        };
        _context.EducationalFiles.Add(file);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetEducationalFile), new { id = file.Id }, file);
    }

    [HttpPut("educationalfiles/{id}")]
    public IActionResult UpdateEducationalFile(int id, [FromBody] EducationalFileDto dto)
    {
        var file = _context.EducationalFiles.Find(id);
        if (file == null) return NotFound();
        file.FileName = dto.FileName;
        file.Description = dto.Description;
        file.Subject = dto.Subject;
        file.EducationalLevel = dto.EducationalLevel;
        file.FilePath = dto.FilePath;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("educationalfiles/{id}")]
    public IActionResult DeleteEducationalFile(int id)
    {
        var item = _context.EducationalFiles.Find(id);
        if (item == null) return NotFound();
        _context.EducationalFiles.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }

    // --- SCHEDULES ---
    [HttpGet("schedules")]
    public IActionResult GetAllSchedules() => Ok(_context.Schedules.ToList());

    [HttpGet("schedules/{id}")]
    public IActionResult GetSchedule(int id)
    {
        var item = _context.Schedules.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("schedules")]
    public IActionResult CreateSchedule([FromBody] ScheduleDto dto)
    {
        var schedule = new Schedule
        {
            Title = dto.Title,
            FilePath = dto.FilePath,
            ActivationDate = dto.ActivationDate
        };
        _context.Schedules.Add(schedule);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetSchedule), new { id = schedule.Id }, schedule);
    }

    [HttpPut("schedules/{id}")]
    public IActionResult UpdateSchedule(int id, [FromBody] ScheduleDto dto)
    {
        var schedule = _context.Schedules.Find(id);
        if (schedule == null) return NotFound();
        schedule.Title = dto.Title;
        schedule.FilePath = dto.FilePath;
        schedule.ActivationDate = dto.ActivationDate;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("schedules/{id}")]
    public IActionResult DeleteSchedule(int id)
    {
        var item = _context.Schedules.Find(id);
        if (item == null) return NotFound();
        _context.Schedules.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }

    // --- ARTICLES ---
    [HttpGet("articles")]
    public IActionResult GetAllArticles() => Ok(_context.Articles.ToList());

    [HttpGet("articles/{id}")]
    public IActionResult GetArticle(int id)
    {
        var item = _context.Articles.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("articles")]
    public IActionResult CreateArticle([FromBody] ArticleDto dto)
    {
        var article = new Article
        {
            Title = dto.Title,
            Content = dto.Content,
            Category = (ArticleCategory)dto.Category
        };
        _context.Articles.Add(article);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetArticle), new { id = article.Id }, article);
    }

    [HttpPut("articles/{id}")]
    public IActionResult UpdateArticle(int id, [FromBody] ArticleDto dto)
    {
        var article = _context.Articles.Find(id);
        if (article == null) return NotFound();
        article.Title = dto.Title;
        article.Content = dto.Content;
        article.Category = (ArticleCategory)dto.Category;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("articles/{id}")]
    public IActionResult DeleteArticle(int id)
    {
        var item = _context.Articles.Find(id);
        if (item == null) return NotFound();
        _context.Articles.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }

    // --- USERS ---
    [HttpGet("users")]
    public IActionResult GetAllUsers() => Ok(_context.Users.ToList());

    [HttpGet("users/{id}")]
    public IActionResult GetUser(int id)
    {
        var item = _context.Users.Find(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost("users")]
    public IActionResult CreateUser([FromBody] UserDto dto)
    {
        var user = new User
        {
            Username = dto.Username,
            PasswordHash = dto.PasswordHash
        };
        _context.Users.Add(user);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
    }

    [HttpPut("users/{id}")]
    public IActionResult UpdateUser(int id, [FromBody] UserDto dto)
    {
        var user = _context.Users.Find(id);
        if (user == null) return NotFound();
        user.Username = dto.Username;
        user.PasswordHash = dto.PasswordHash;
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("users/{id}")]
    public IActionResult DeleteUser(int id)
    {
        var item = _context.Users.Find(id);
        if (item == null) return NotFound();
        _context.Users.Remove(item);
        _context.SaveChanges();
        return NoContent();
    }
} 