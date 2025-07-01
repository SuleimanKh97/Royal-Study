using Microsoft.AspNetCore.Mvc;

// The namespace should match your project's folder structure.
namespace RoyalStudy.Controllers;

[ApiController]
[Route("api/[controller]")] // This sets the base route to "api/products"
public class ProductsController : ControllerBase
{
    // --- Placeholder for Database Context and Services ---
    // In a real application, you would inject your DbContext or a service here.
    // For example:
    // private readonly ApplicationDbContext _context;
    // public ProductsController(ApplicationDbContext context)
    // {
    //     _context = context;
    // }
    // --- End of Placeholder ---


    // GET: api/products
    // Gets a list of all products.
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        // Placeholder: Replace with code to fetch all products from the database.
        var products = new[]
        {
            new { Id = 1, Name = "دوسية فيزياء التوجيهي", Price = 10.50m },
            new { Id = 2, Name = "قلم حبر أزرق", Price = 0.50m }
        };

        return Ok(products); // Returns a 200 OK with the list of products.
    }

    // GET: api/products/5
    // Gets a single product by its ID.
    [HttpGet("{id}")]
    public IActionResult GetProductById(int id)
    {
        // Placeholder: Replace with code to find a product by its ID in the database.
        if (id <= 0)
        {
            return BadRequest("Invalid product ID.");
        }

        // Simulating finding a product.
        var product = new { Id = id, Name = $"Product Name for ID {id}", Price = 15.00m };

        // In a real scenario, you would check if the product was found.
        // if (product == null)
        // {
        //     return NotFound(); // Returns a 404 Not Found if the product doesn't exist.
        // }

        return Ok(product); // Returns a 200 OK with the product data.
    }

    // POST: api/products
    // Creates a new product.
    [HttpPost]
    public IActionResult CreateProduct([FromBody] object newProduct) // Replace 'object' with a specific Product DTO/Model class.
    {
        if (newProduct == null)
        {
            return BadRequest("Product data is null."); // Returns a 400 Bad Request if the request body is empty.
        }

        // Placeholder: Replace with code to add the new product to the database and save changes.
        // After saving, it's a best practice to return the created object with its new ID.
        var createdProduct = new { Id = new Random().Next(100, 1000), Data = newProduct };

        // Returns a 201 Created status with the location of the new resource and the resource itself.
        return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
    }

    // PUT: api/products/5
    // Updates an existing product.
    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] object updatedProduct) // Replace 'object' with a specific Product DTO/Model class.
    {
        if (id <= 0)
        {
            return BadRequest("Invalid product ID.");
        }

        if (updatedProduct == null)
        {
            return BadRequest("Product data is null.");
        }

        // Placeholder: Find the existing product in the database.
        // If not found, return NotFound().
        // var existingProduct = _context.Products.Find(id);
        // if (existingProduct == null)
        // {
        //     return NotFound();
        // }

        // Update its properties and save changes.

        return NoContent(); // Returns a 204 No Content, indicating success without sending back any data.
    }

    // DELETE: api/products/5
    // Deletes a product.
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid product ID.");
        }

        // Placeholder: Find the product in the database.
        // If not found, return NotFound().
        // var productToDelete = _context.Products.Find(id);
        // if (productToDelete == null)
        // {
        //     return NotFound();
        // }

        // Remove the product and save changes.

        return NoContent(); // Returns a 204 No Content, indicating success.
    }
}
