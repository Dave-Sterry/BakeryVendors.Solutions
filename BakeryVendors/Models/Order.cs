using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description, string price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = 2;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}