public class Product
{
    private int _quantity;

    private int _price;

    private string _productName;

    private string _productId;


    public Product(string name, int price, int qunatity, string id)
    {
        _productName = name;
        _price = price * qunatity;
        _quantity = qunatity;
        _productId = id;
    }

    public int GetPrice()
    {
        return _price;
    }

    public string ProductDisplay()
    {
        return($"product ID: {_productId} \n {_quantity} {_productName}");
    }
}