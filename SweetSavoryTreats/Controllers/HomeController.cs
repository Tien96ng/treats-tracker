
using Microsoft.AspNetCore.Mvc;
using SweetSavoryTreats.Models;
using System.Linq;


namespace Recipe.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetSavoryTreatsContext _db;
    public HomeController(SweetSavoryTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
  }
}