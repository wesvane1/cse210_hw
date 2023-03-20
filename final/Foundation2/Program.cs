using System;

class Program
{
    static List<Address> orderList = new List<Address>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        // ! There is a bool set to check if the address is in the USA, this will be useful for the added shipping cost

        Product p1 = new Product("Meat", 1, 10, 15);
        Product p2 = new Product("Cheese", 2, 3, 12);
        Product p3 = new Product("Bread", 3, 2, 11);
        Product p4 = new Product("Sauce", 4, 5, 10);
        Product p5 = new Product("Butter", 5, 5, 100);

        Address a1 = new Address("455 South 2nd East APT 701", "Rexburg", "Idaho", 83440, "USA");
        Customer c1 = new Customer("Wes", "Vane");
        Console.WriteLine(a1.GetAddress());
        
        Address a2 = new Address("3893 North Legacy Common Ave.", "Meridian", "Idaho", 83646, "USA");
        Customer c2 = new Customer("Savanna", "Boston");
        Console.WriteLine(a2.GetAddress());

        Address a3 = new Address("Red Bull Ring Street", "Spielberg", "Austria", 8724, "Austria");
        Customer c3 = new Customer("Max", "Verstappen");
        Console.WriteLine(a3.GetAddress());

        Console.WriteLine(a1.IsInUSA()); // * Returns true
        Console.WriteLine(a2.IsInUSA()); // * Returns true
        Console.WriteLine(a3.IsInUSA()); // * Returns false
        Console.WriteLine(p1.getPrice()); // * Each of these lines returns the price of the product
        Console.WriteLine(p2.getPrice());
        Console.WriteLine(p3.getPrice());

    }
}