using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SweetSavoryTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetSavoryTreats.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetSavoryTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public FlavorsController(UserManager<ApplicationUser> userManager, SweetSavoryTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor, int treatId)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      if (treatId != 0)
      {
        _db.FlavorTreats.Add(new FlavorTreat() { FlavorId = flavor.FlavorId, TreatId = treatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}