class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new("John Doe", address1);
        Customer customer2 = new("Jane Smith", address2);

        // Create products
        Product product1 = new("Laptop", "L001", 800m, 1);
        Product product2 = new("Mouse", "M002", 25m, 2);
        Product product3 = new("Keyboard", "K003", 45m, 1);
        Product product4 = new("Monitor", "M004", 150m, 1);

        // Create orders and add products
        Order order1 = new(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
