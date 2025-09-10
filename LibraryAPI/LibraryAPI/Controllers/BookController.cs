using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetBooks()
        {
            //TODO: Implement retrieval All logic
            return Ok(new { Message = "Get all books" });
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(Guid id)
        {
            //TODO: Implement retrieval logic
            return Ok(new { Message = $"Get book with ID: {id}" });
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] object bookCreateDto)
        {
            //TODO: Implement creation logic
            return CreatedAtAction(nameof(GetBookById), new { id = Guid.NewGuid() }, bookCreateDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(Guid id, [FromBody] object bookUpdateDto)
        {
            //TODO: Implement update logic
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            //TODO: Implement deletion logic
            return NoContent();
        }

    }
}
