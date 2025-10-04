using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Garry", "999 East 4530 South", "Springville", "Utah", "United States Of America");
        order1.AddProduct("Bannana", "BA324", 4.99, 6);
        order1.AddProduct("Apple", "AP667", 7.50, 12);
        order1.AddProduct("PlayStation5", "PL999", 599.99, 1);
        string shippingLabel1 = order1.MakeShippingLabel();
        Console.WriteLine($"{shippingLabel1}");
        Console.WriteLine("");
        string packingLabel1 = order1.MakePackingLabel();
        Console.WriteLine($"{packingLabel1}");
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");

        Order order2 = new Order("Steve", "1324 West 590 South", "Toronto", "Ontario", "Canada");
        order2.AddProduct("PlayStation5", "PL999", 599.99, 1);
        order2.AddProduct("Orange", "OR676", 6.99, 8);
        order2.AddProduct("pineapple", "PI001", 10.85, 1);
        string shippingLabel2 = order2.MakeShippingLabel();
        Console.WriteLine($"{shippingLabel2}");
        Console.WriteLine("");
        string packingLabel2 = order2.MakePackingLabel();
        Console.WriteLine($"{packingLabel2}");
        Console.WriteLine("");
    }
}