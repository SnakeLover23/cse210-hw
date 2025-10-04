using System.Numerics;

public class Order
{
    Customer _customer = new Customer();
    List<Product> _products = new List<Product>();
    public Order(string name, string street, string city, string stateProvince, string country)
    {
        _customer = new Customer(name, street, city, stateProvince, country);
    }
    public void AddProduct(string name, string productID, double price, int quantity)
    {
        Product newProduct = new Product(name, productID, price, quantity);
        _products.Add(newProduct);
    }
    public string MakePackingLabel()
    {
        string packingLabel = "";
        double total = 0;
        foreach (Product product in _products)
        {
            string name = product.GetName();
            string productID = product.GetID();
            double price = product.GetPrice();
            int quantity = product.GetQuantity();
            double totalTemp = product.GetTotal();
            packingLabel = packingLabel + $"{name} - ID: {productID} - Price Per: ${price:f2} - Quantity: {quantity} - Price: ${totalTemp:f2}\n";
            total = total + totalTemp;
        }
        bool isUSA = _customer.IsUSA();
        if (isUSA == true)
        {
            total = total + 5;
            packingLabel = packingLabel + "Shipping and handeling: $5.00\n";
        }
        else
        {
            total = total + 35;
            packingLabel = packingLabel + "Shipping and handeling: $35.00\n";
        }
        packingLabel = packingLabel + $"Total: ${total:f2}";

        return packingLabel;
    }
    public string MakeShippingLabel()
    {
        string shippingLabel = "";
        string name = _customer.GetName();
        Address address = _customer.GetAddress();
        string addressTemp = address.ReturnAddress();
        shippingLabel = shippingLabel + $"Name: {name}\n{addressTemp}";


        return shippingLabel;
    }
}