using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using BakeryVendors.Models;

namespace BakeryVendor.Controllers
{

  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/vendors")]

    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

  }

}