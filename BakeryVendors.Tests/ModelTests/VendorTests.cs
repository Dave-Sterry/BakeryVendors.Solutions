using  Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendors.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsNameOfVendor_String()
    {
      string name = "VendorTest";
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_ObjectList()
    {
      string name1 = "Coffeeshop";
      string name2= "newseasons";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorWithId_Int()
    {
      string name = "VendorTest";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_FindsReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "CoffeeShop";
      string vendor2 = "NewSeaons";
      Vendor newVendor1  = new Vendor(vendor1);
      Vendor newVendor2 = new Vendor(vendor2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title = "CoffeeShop";
      string description = "5 pastries";
      string price = "$10";
      string date = "11/12/20";
      Order newOrder1 = new Order(title, description, price, date);
      List<Order> newOrder = new List<Order>{ newOrder1 };
      string name = "New Seasons";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder1);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newOrder, result);
    }
  }
}