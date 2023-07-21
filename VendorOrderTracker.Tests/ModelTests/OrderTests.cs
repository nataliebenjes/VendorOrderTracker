using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 44, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "olive bread";
      string description = "olive bread order";
      int price = 3;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newOrder = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrder_OrderList()
    {
      string title01 = "olive bread";
      string title02 = "olive bread";
      string description01 = "olive bread order";
      string description02 = "olive bread order";
      int price01 = 3;
      int price02 = 3;
      string date01 = "date";
      string date02 = "date";
      Order newItem1 = new Order(title01, description01, price01, date01);
      Order newItem2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newItem1, newItem2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}