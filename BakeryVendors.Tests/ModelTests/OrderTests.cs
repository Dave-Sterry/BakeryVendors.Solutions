using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendors.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]

  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrder_ReturnDetails_String()
    {
      string title = "CoffeeShop";
      string description = "5 pastries";
      string price = "$10";
      string date = "11/12/20";
      Order newOrder = new Order(title, description, price, date);
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      string priceResult = newOrder.Price;
      string dateResult = newOrder.Date;
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, descriptionResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);
    }
    
    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      string title = "CoffeeShop";
      string description = "5 pastries";
      string price = "$10";
      string date = "11/12/20";
      Order newOrder = new Order(title, description, price, date);

      int result = newOrder.Id;

      Assert.AreEqual(1,result);

    }
  }
  
}