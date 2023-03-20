public class Product
{
  // Dictionary<string, int> productList = new Dictionary<string, int>();
  // prod_name, prod_id, prod_price, prod_quant
  private List<string> productList = new List<string>();
  private string _prodName;
  private int _prodId;
  private int _prodPrice;
  private int _storeProdQuant;

  // ! These two variables are for calculating the quantity and price of items in stock.
  // private int _quantity;
  // private int _totalPrice;

  public Product(string prodName, int prodId, int prodPrice, int storeProdQuant)
  {
    _prodName = prodName;
    _prodId = prodId;
    _prodPrice = prodPrice;
    _storeProdQuant = storeProdQuant;

    productList.Add($"{prodName}, {prodId}, {prodPrice}, {storeProdQuant}");
  }

  public string getProdName()
  {
    return _prodName;
  }
  public int getProdId()
  {
    return _prodId;
  }
  public int getPrice()
  {
    return _prodPrice;
  }
  public int getProdQuant()
  {
    return _storeProdQuant;
  }
}