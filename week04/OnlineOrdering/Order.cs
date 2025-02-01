using System.Net.Http.Headers;
using System.Net.Sockets;

public class Order {
    private List <Product> _products = new List<Product>();
    private Customer _customer;
    private Address _address;

    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double _total = 0;
        foreach (var item in _products)
        {
            _total += item.GetTotalCost();
        }
        if (_address.IsInUsa())
        {
            _total += 5;
        }
        else
        {
            _total += 35;
        }
        return _total;
    }

    public string GetOrder()
    {
        string _header = "Name".PadRight(20) + "ID".PadRight(10) + "Price".PadRight(10) + "Quantity".PadRight(10) + "Subtotal".PadRight(10);
        
        string _itens = "";

        foreach (var item in _products)
        {
            _itens += item.DisplayComplete() + item.GetTotalCost().ToString("C").PadRight(10) + "\n";
        }
        string _order = _customer.GetName() + "\n" + _header + "\n" + _itens + "Total Cost: " + GetTotalCost().ToString("C");
    
        return _order;
    }

        public string GetPackingLabel()
        {
            string _header = "Name".PadRight(20) + "ID".PadRight(10);
            string _label = "";
            foreach (var item in _products)
        {
                _label += item.DisplayResume();
        }
            return _header + "\n" + _label;
        }

        public string GetShippingLabel()
        {
            string _label = _customer.GetName() + "\n" + _address.GetFullAddress();
            return _label;
        }
}