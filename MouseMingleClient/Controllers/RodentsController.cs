using Microsoft.AspNetCore.Mvc;
using MouseMingleClient.Models;

namespace MouseMingleClient.Controllers;

public class RodentsController : Controller
{
  public IActionResult Index()
  {
    List<Rodent> rodents = Rodent.GetAll();

    return View(rodents);
  }

  public IActionResult Details(int id)
  {
    var rodent = Rodent.GetDetails(id);

    return View(rodent);
  }

// will need User Id to display join b/w user and their rodent.
  public IActionResult RodentProfile()
  {
    return View();
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Rodent rodent)
  {
    Rodent.Post(rodent);

    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    var rodent = Rodent.GetDetails(id);

    return View(rodent);
  }

  [HttpPost]
  public ActionResult Edit(Rodent rodent)
  {
    Rodent.Put(rodent);
    return RedirectToAction("Details", new { id = rodent.RodentId });
  }

  public ActionResult Delete(int id)
  {
    var rodent = Rodent.GetDetails(id);

    return View(rodent);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Rodent.Delete(id);
    return RedirectToAction("Index");
  }

  [HttpPost]
  public ActionResult AddUpVote(int id, string vote)
  {
    Rodent rodent = Rodent.GetDetails(id);
    if (vote == "yes")
    {
      rodent.UpVote++;
    }
    else if (vote == "no")
    {
      rodent.UpVote--;
    }
    Rodent.Put(rodent);
    return RedirectToAction("Index");
  }
}