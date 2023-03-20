public class Order
{
  // ! Make a list in the main class like this static List<Order> orderList = new List<Order>();

  private string _itemOrdered;
  private int _quantity;
  private int _totalCost;

  public Order(string itemOrdered, int quantity, int totalCost)
  {
    _itemOrdered = itemOrdered;
    _quantity = quantity;
    _totalCost = totalCost;
  }

  public string getOrder()
  {
    Console.WriteLine("What would you like to get?: ");
    string CustRequest = Console.ReadLine();
    return CustRequest;
  }
}