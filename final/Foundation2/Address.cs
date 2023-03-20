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

  // public string SetFullAddress()
  // {
  //   GetStreetAddress();
  //   GetCity();
  //   GetState();
  //   GetZipCode();
  //   GetCountry();
  //   return ($"{_streetAddress} {_city}, {_state}, {_zipCode}, {_country}");
  // }
  // public string GetStreetAddress()
  // {
  //   Console.Write("What is the street you live on?: ");
  //   string _streetAddress = Console.ReadLine();
  //   return _streetAddress;
  // }
  // public string GetCity()
  // {
  //   Console.Write("What is the city you live in?: ");
  //   string _city = Console.ReadLine();
  //   return _city;
  // }
  // public string GetState()
  // {
  //   Console.Write("What is the state you live in?: ");
  //   string _state = Console.ReadLine();
  //   return _state;
  // }
  // public int GetZipCode()
  // {
  //   Console.Write("What is your zip code?: ");
  //   int _zipCode = int.Parse(Console.ReadLine());
  //   return _zipCode;
  // }
  // public string GetCountry()
  // {
  //   Console.Write("What country do you live in?: ");
  //   string _country = Console.ReadLine();
  //   return _country;
  // }
}