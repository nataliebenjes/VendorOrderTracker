using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    //create properties of Vendor
    private static List<Vendor> _allthevendors = new List<Vendor> {}; 
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; } //Id can only be set within the constructor
    public List<Order> Orders { get; set; } //allows us to get Orders associated with a vendor

    public Vendor(string vendorName)
    { //this is Vendor constructor
      Name = vendorName;
      _allthevendors.Add(this); //adds the vendor to _allthevendors List
      Id = _allthevendors.Count;
      Orders = new List<Order>{}; //Orders property is empty list od Order objects
    }
    public static void ClearAll()
    {
      _allthevendors.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _allthevendors;
    }
    public static Vendor Find(int searchId)
    {
      return _allthevendors[searchId-1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}