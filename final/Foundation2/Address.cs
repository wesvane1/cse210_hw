public class Address
{
  private string _streetAddress;
  private string _city;
  private string _state;
  private int _zipCode;
  private string _country;
  public Address(string streetAddress, string city, string state, int zipCode, string country)
  {
    _streetAddress = streetAddress;
    _city = city;
    _state = state;
    _zipCode = zipCode;
    _country = country;
  }

  public bool IsInUSA()
  {
    if (_country == "USA")
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public string GetAddress()
  {
    return $"{_streetAddress} \n{_city}, {_state} \n{_zipCode}, {_country}";
  }
}