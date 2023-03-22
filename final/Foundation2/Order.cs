public class Order
{
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