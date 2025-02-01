using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        List<Order> orders = new List<Order>();
        
        Address _address1 = new Address ("123 Main St", "New York", "NY", "USA");
        Customer _customer1 = new Customer ("John", "Doe", _address1);
        Order _order1 = new Order(_customer1, _address1);
        _order1.AddProduct(new Product ("Laptop", 101, 1200, 1));
        _order1.AddProduct(new Product ("Mouse", 102, 25.5, 1));
        orders.Add(_order1);

        Address _address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer _customer2 = new Customer("Jane", "Smith", _address2);
        Order _order2 = new Order(_customer2, _address2);
        _order2.AddProduct(new Product("Keyboard", 103, 50, 1));
        _order2.AddProduct(new Product("Monitor", 104, 300, 2));
        _order2.AddProduct(new Product("Headphones", 105, 80, 1));
        orders.Add(_order2);

        foreach (var item in orders)
        {
            Console.WriteLine("Order:\n\n" + item.GetOrder() + "\n\nPacking Label:\n\n" + item.GetPackingLabel() + "\n\nShipping Label:\n\n" + item.GetShippingLabel() + "\n");
        }
    }
}