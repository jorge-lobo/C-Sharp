using _23_05_16_Encomenda.Entities;
using _23_05_16_Encomenda.Entities.Enum;
using System.Globalization;
using System.Collections.Generic;
using System.Text.Encodings;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;

        Console.WriteLine("Enter client data: ");
        Console.WriteLine("Name: ");
        string clientName = Console.ReadLine();
        Console.WriteLine("Email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Birth date (dd/MM/yyyy): ");
        DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Order Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Console.WriteLine("How many items to this order?: ");
        int N = int.Parse(Console.ReadLine());

        Client client = new Client(clientName, email, birthDate);
        Order order = new Order(DateTime.Now, status, client);

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"Enter #{i} item data: ");
            Console.WriteLine("Product name: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Product price: ");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(productName, productPrice);

            Console.WriteLine("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            OrderItem item = new OrderItem(product, productPrice, quantity);

            order.Items.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine(order);






















    }
}