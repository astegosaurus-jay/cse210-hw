public class Address
{
    private string _streetAddress;

    private string _city;

    private string _state;

    private string _country;

    private bool _local;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool Local()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public string FullAddress()
    {
        return($"{_streetAddress} \n {_city} {_state} \n {_country}");
    }
}