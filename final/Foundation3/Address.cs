public class Address
{
  private string _streetAddress;
  private string _cityName;
  private string _stateName;
  private int _zipCode;

  public Address(string streetAddress, string cityName, string stateName, int zipCode)
  {
    _streetAddress = streetAddress;
    _cityName = cityName;
    _stateName = stateName;
    _zipCode = zipCode;
  }

  public string GetAddress()
  {

    return $"{_streetAddress} \n{_cityName}, {_stateName} {_zipCode}";
  }
}