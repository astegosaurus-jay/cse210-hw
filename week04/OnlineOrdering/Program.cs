using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 STREET WAY", "cool city", "cool state", "USA");
        Customer customer1 = new Customer("john", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Vanilla Ice cream", 5, 2, "555");
        order1.AddProduct(product1);
        order1.AddToTotal(product1);

        Product product2 = new Product("chocolate ice cream", 7, 3, "556");
        order1.AddProduct(product2);
        order1.AddToTotal(product2);

        order1.Shipping();
        order1.PackingLabel();
        order1.ShippingLabel();



        Address address2 = new Address("somewhere street", "someplace city", "someplace state", "a country");
        Customer customer2 = new Customer("johnina", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("strawberry icecream", 4, 4, "557");
        order2.AddProduct(product3);
        order2.AddToTotal(product3);

        Product product4 = new Product("mint ice cream", 3, 5, "558");
        order2.AddProduct(product4);
        order2.AddToTotal(product4);

        order2.Shipping();
        order2.PackingLabel();
        order2.ShippingLabel();

    }
}