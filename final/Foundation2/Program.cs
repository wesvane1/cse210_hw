using System;

class Program
{
    static List<String> orderList = new List<String>();
    static List<int> itemsPrice = new List<int>();
    static List<string> items = new List<string>();
    static Dictionary<string, int> itemsCount = new Dictionary<string, int>();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        // ! There is a bool set to check if the address is in the USA, this will be useful for the added shipping cost

        Order o1 = new Order();

        Product p1 = new Product();

        Address a1 = new Address("455 South 2nd East APT 701", "Rexburg", "Idaho", 83440, "USA");
        Customer c1 = new Customer("Wes", "Vane");
        // Console.WriteLine(a1.GetAddress());

        Order o2 = new Order();
        Product p2 = new Product();
        Address a2 = new Address("Red Bull Ring Street", "Spielberg", "Austria", 8724, "Austria");
        Customer c2 = new Customer("Max", "Verstappen");

        // This takes the order and splits it by spaces and adds it to a list
        string CustRequest = o1.getOrder();
        orderList = !string.IsNullOrEmpty(CustRequest) ? CustRequest.Split(' ').ToList() : new List<string>();
        int i = 0;
        int testPrice = 0;

        // This block of code adds all prices to a list
        foreach (string order in orderList)
        {
            int itemPrice = p1.itemPrice(orderList[i]);
            itemsPrice.Add(itemPrice);
            i++;
        }

        // This block of code returns the product_id
        int idI = 0;
        foreach (string order in orderList)
        {
            string itemId = p1.itemId(orderList[idI]);
            items.Add(itemId);
            idI++;
        }

        // This block of code will return the items that are repeated for the packing label.
        for (int j = 0; j < items.Count; j++)
        {
            if (j == items.Count - 1 || items[j] != items[j + 1])
            {
                int count = 1;
                if (itemsCount.ContainsKey(items[j]))
                {
                    count += itemsCount[items[j]];
                }
                itemsCount[items[j]] = count;
            }
        }
        Console.WriteLine("\nPacking Order");
        foreach (KeyValuePair<string, int> pair in itemsCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }

        // This block of code adds all prices together
        foreach (int number in itemsPrice)
        {
            testPrice+=number;
        }

        // This block of code adds a shipping cost to the order
        if (a1.IsInUSA()==true)
        {
            testPrice+=5;
        }
        else
        {
            testPrice+=35;
        };
        Console.WriteLine($"\nThe order for {c1.getCustomerName()} at\n{a1.GetAddress()} \nwill cost ${testPrice}");

    }
}