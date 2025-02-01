public class Product {
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product (string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity =quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string DisplayComplete()
    {
        return _name.PadRight(20) + _id.ToString().PadRight(10) + "$ " + _price.ToString("F2").PadRight(8) + _quantity.ToString().PadRight(10);
    }

    public string DisplayResume()
    {
        return _name.PadRight(20) + _id.ToString().PadRight(10);
    }
}