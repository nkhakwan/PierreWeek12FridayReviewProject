using Microsoft.AspNetCore.Mvc;
using System;
namespace Sweet.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}