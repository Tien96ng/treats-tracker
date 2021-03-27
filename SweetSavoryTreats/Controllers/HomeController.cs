using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SweetSavoryTreats.Models;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

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