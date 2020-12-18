using Microsoft.AspNetCore.Mvc;

namespace BakeryVendor.Controllers
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