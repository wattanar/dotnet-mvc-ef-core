using Data.Contexts;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Api
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthorController : ControllerBase
  {
    private AppDbContext _appDbContext;

    public AuthorController(
        AppDbContext appDbContext
    )
    {
      _appDbContext = appDbContext;
    }

    /// <summary>
    /// Get all authors
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IEnumerable<Author> GetAuthors()
    {
      var authors = _appDbContext.Author;
      return authors;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Author> GetAuthors(int id)
    {
      var author = _appDbContext.Author.Find(id);
      if (author is null)
      {
        return NotFound();
      }

      return author;
    }
  }
}