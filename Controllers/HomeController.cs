using System.Collections.Generic;
using Data.Contexts;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetAPI.Controllers
{
  public class HomeController : Controller
  {
    private AppDbContext _appDbContext;
    public HomeController(
      AppDbContext appDbContext
    )
    {
      _appDbContext = appDbContext;
    }
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Book()
    {
      List<Book> books = _appDbContext.Book
        .Include(x => x.Author)
        .ToList();

      return View(books);
    }

    public IActionResult Author()
    {
      return View();
    }

    public IActionResult CreateBook()
    {
      return View();
    }
  }
}