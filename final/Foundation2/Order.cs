public class Order
{
  // ! Make a list in the main class like this static List<Order> orderList = new List<Order>();

  static List<String> orderList = new List<String>();

  public Order()
  {
  }

  public string getOrder()
  {
    Console.WriteLine("What would you like to get? (Meat, Cheese, Sauce, Bread): ");
    string CustRequest = Console.ReadLine();
    return CustRequest;
  }
}