using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    private static List<Order> _alltheorders = new List<Order> { };

    public Order(string title, string description, int price, int date)
    {
        Title = title;
        Description = description;
        Price = price;
        Date = date;
    }
  }
}