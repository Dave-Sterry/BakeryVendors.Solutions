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
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrderList_OrderList()
    {
      string title = "CoffeeShop";
      string description = "5 pastries";
      string price = "$10";
      string date = "11/12/20";
      Order newOrder1 = new Order(title, description, price, date);
      string title2 = "GroceryStore";
      string description2 = "100 pastries";
      string price2 = "$300";
      string date2 = "11/15/20";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newOrder = new List<Order> {newOrder1, newOrder2};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrder, result);

    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "CoffeeShop";
      string description = "5 pastries";
      string price = "$10";
      string date = "11/12/20";
      Order newOrder = new Order(title, description, price, date);

      int result = newOrder.Id;

      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title = "CoffeeShop";
      string description = "5 pastries";
      string price = "$10";
      string date = "11/12/20";
      Order newOrder1 = new Order(title, description, price, date);
      string title2 = "GroceryStore";
      string description2 = "100 pastries";
      string price2 = "$300";
      string date2 = "11/15/20";
      Order newOrder2 = new Order(title2, description2, price2, date2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
  
}