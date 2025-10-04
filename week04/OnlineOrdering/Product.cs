public class Product
{
    string _name;
    string _productID;
    double _price;
    int _quantity;
    double _total;
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        double quantityTemp = quantity;
        _total = _price * quantityTemp;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _productID;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetTotal()
    {
        return _total;
    }
}