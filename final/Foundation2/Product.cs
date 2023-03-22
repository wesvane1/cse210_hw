public class Product
{
  // Dictionary<string, int> productList = new Dictionary<string, int>();
  // prod_name, prod_id, prod_price, prod_quant
  // private List<string> productList = new List<string>();
  // private string _prodName;
  // private int _prodId;
  // private int _prodPrice;
  // private int _storeProdQuant;

  // ! These two variables are for calculating the quantity and price of items in stock.
  // private int _quantity;
  // private int _totalPrice;

  public Product()
  {
    // _prodName = prodName;
    // _prodId = prodId;
    // _prodPrice = prodPrice;
    // _storeProdQuant = storeProdQuant;

    // productList.Add($"{prodName}, {prodId}, {prodPrice}, {storeProdQuant}");
  }

  // public string getProdName()
  // {
  //   return _prodName;
  // }
  // public int getProdId()
  // {
  //   return _prodId;
  // }
  // public int getPrice()
  // {
  //   return _prodPrice;
  // }
  // public int getProdQuant()
  // {
  //   return _storeProdQuant;
  // }

  public int itemPrice(string prodName)
  {
    if (prodName == "meat")
    {
      int itemPrice = 5;
      return itemPrice;
    }
    else if (prodName == "cheese")
    {
      int itemPrice = 4;
      return itemPrice;
    }
    else{
      int itemPrice = 0;
      return itemPrice;
    }
  }

  public string itemId(string prodName)
  {
      if (prodName == "meat")
    {
      string itemId = "000";
      return itemId;
    }
    else if (prodName == "cheese")
    {
      string itemId = "010";
      return itemId;
    }
    else if (prodName == "sauce")
    {
      string itemId = "020";
      return itemId;
    }
    else if (prodName == "bread")
    {
      string itemId = "030";
      return itemId;
    }
    else{
      string itemId = "040";
      return itemId;
    }
  }
}