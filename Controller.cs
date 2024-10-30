using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/book")]

public class BookController(IBookRepository bookRepository) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetBooks()
    {
        return Ok(ApiResponse<IEnumerable<BookReadDTO>>.Success(bookRepository.GetBooks()));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Createbook([FromBody] BookCreateDTO bookCreateDTO)
    {
        return Ok(ApiResponse<bool>.Success(bookRepository.CreateBook(bookCreateDTO)));
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DeleteBook([FromQuery] int id)
    {
        return Ok(ApiResponse<bool>.Success(bookRepository.DeleteBook(id)));
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult UpdateBook([FromBody] BookUpdateDTO bookUpdateDTO)
    {
        return Ok(ApiResponse<bool>.Success(bookRepository.UpdateBook(bookUpdateDTO)));
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetBookByID(int id)
    {
        return Ok(ApiResponse<BookReadDTO>.Success(bookRepository.GetBookById(id)));
    }
}