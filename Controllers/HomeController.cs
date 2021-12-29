using Microsoft.AspNetCore.Mvc;

namespace DotNetAPI.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}