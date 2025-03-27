using System.Numerics;

public class Order 
{
   private List<Product> _products = new List<Product>();
   private Customer _customer;

   private int _total;

   private int _grandTotal;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void AddToTotal(Product price)
    {
        _total += price.GetPrice();
    }

    public void Shipping()
    {
        if (_customer.Local2() == true)
        {
            _grandTotal = 5 + _total;
            Console.WriteLine($"Grand total {_grandTotal}");
        }
        else
        {
            _grandTotal = 35 + _total;
            Console.WriteLine($"Grand total {_grandTotal}");
        }
    }

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine(product.ProductDisplay());
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }

    
}