using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }

    public Order(string title, string description, string price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      //_instances.Add(this);
    }
  }
}