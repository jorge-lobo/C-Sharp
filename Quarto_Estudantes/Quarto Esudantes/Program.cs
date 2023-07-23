using Quarto_Esudantes;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudante[] vet = new Estudante[10];

        Console.WriteLine("Indique o número de quartos a alugar: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("Nome do estudante: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            vet[quarto] = new Estudante(nome, email);
        }

        Console.WriteLine();
        Console.WriteLine("Quartos Ocupados:");

        for (int i = 0 ; i < 10 ; i++)
        {
            if (vet[i] !=null)
            {
                Console.WriteLine(i + ": " + vet[i]);
            }

        }

    }
}