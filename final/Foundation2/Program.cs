using System;

class Program
{
    static List<Address> orderList = new List<Address>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        // ! There is a bool set to check if the address is in the USA, this will be useful for the added shipping cost

        Address a1 = new Address("3893 North Legacy Common Ave.", "Meridian", "Idaho", 83646, "USA");
        Address a2 = new Address("3893 North Legacy Common Ave.", "Meridian", "Idaho", 83646, "CA");
        // The line below prints if the address is in the USA or not.
        Console.WriteLine(a1.IsInUSA());
        Console.WriteLine(a2.IsInUSA());
    }
}