using Data.Contexts;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
  public class BookController : Controller
  {
    private AppDbContext _appDbContext;

    public BookController(
        AppDbContext appDbContext
    )
    {
      _appDbContext = appDbContext;
    }

    public IActionResult Create([FromForm] CreateBookModel createBook)
    {
      var newBook = new Book
      {
        Title = createBook.BookName,
        AuthorId = 1
      };

      _appDbContext.Add(newBook);
      _appDbContext.SaveChanges();

      return Redirect("/Home/Book");
    }
  }
}