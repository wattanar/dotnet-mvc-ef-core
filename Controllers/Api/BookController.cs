using Data.Contexts;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Api
{
  [Route("api/[controller]")]
  [ApiController]
  public class BookController : ControllerBase
  {
    private AppDbContext _appDbContext;

    public BookController(
        AppDbContext appDbContext
    )
    {
      _appDbContext = appDbContext;
    }

    /// <summary>
    /// Get all Books
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IEnumerable<Book> GetBooks()
    {
      var books = _appDbContext.Book;
      return books;
    }

    /// <summary>
    /// Get book by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id:int}")]
    public ActionResult<Book> GetBooks(int id)
    {
      var book = _appDbContext.Book.Find(id);

      if (book is null)
      {
        return NotFound();
      }

      return book;
    }
  }
}