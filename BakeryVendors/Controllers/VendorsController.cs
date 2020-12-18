using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryVendors.Models;

namespace BakeryVendor.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]

    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]

    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]

    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]

    public ActionResult Show(int id)
    {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor choosenVendor = Vendor.Find(id);
    List<Order> choosenOrder = choosenVendor.Orders;
    model.Add("vendor", choosenVendor);
    model.Add("orders", choosenOrder);
    return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]

    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderPrice, string orderDate )
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor choosenVendor = Vendor.Find(vendorId);
      Order choosenOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      choosenVendor.AddOrder(choosenOrder);
      List<Order> vendorOrders = choosenVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", choosenVendor);
      return View("Show", model);
    }




  }
}