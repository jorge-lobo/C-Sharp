using System.Globalization;
using _23_05_23_Produtos.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default; //€

        Console.Write("Enter the number of products: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine();

        List<Product> products = new List<Product>();

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common , used or imported (c/u/i) ?: ");
            char a = char.Parse(Console.ReadLine());

            if (a != 'c' && a != 'C' && a != 'i' && a != 'I' && a != 'u' && a != 'U')
            {
                Console.WriteLine("Wrong value, Please try again");
                Console.Write("Common , used or imported (c/u/i) ?: ");
                a = char.Parse(Console.ReadLine());
            }

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (a == 'c' || a == 'C')
            {
                products.Add(new Product(name, price));
            }
            else if (a == 'u' || a == 'U')
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine());
                products.Add(new UsedProduct(name, price, manufactureDate));
            }
            else if (a == 'i' || a == 'I')
            {
                Console.Write("Customs fee: ");
                double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products.Add(new ImportedProduct(name, price, customsFee));
            }
            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("PRICE TAGS:");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }














    }
}