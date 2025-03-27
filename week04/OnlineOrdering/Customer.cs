public class Customer
{
    private string _customerName;

    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool Local2()
    {
        return _address.Local();
    }

    public string GetName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _address.FullAddress();
    }
}