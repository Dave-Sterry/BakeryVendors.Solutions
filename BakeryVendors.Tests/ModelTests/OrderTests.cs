using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendors.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]

  public class OrderTest
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
  
}