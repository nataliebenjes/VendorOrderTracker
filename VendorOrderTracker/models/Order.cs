using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _alltheorders = new List<Order> { };

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _alltheorders.Add(this);
      Id = _alltheorders.Count;
    }
    public static List<Order> GetAll()
    {
      return _alltheorders;
    }

    public static void ClearAll()
    {
      _alltheorders.Clear();
    }
    public static Order Find(int searchId)
    {
      return _alltheorders[searchId - 1];
    }
  }
}