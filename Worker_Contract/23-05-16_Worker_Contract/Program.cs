using _23_05_16_Worker_Contract.Entities.Enums;
using _23_05_16_Worker_Contract.Entities;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default; //código para ler o €


        Console.WriteLine("Enter department's name: ");
        string deptName = Console.ReadLine();
        Console.WriteLine("Enter worker data: ");
        Console.WriteLine("Name:");
        string workerName = Console.ReadLine();
        Console.WriteLine("Level (Junior/Mid_Level/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.WriteLine("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department department = new Department(deptName);
        Worker worker = new Worker(workerName, level, baseSalary, department);

        Console.WriteLine("How many contracts to this worker: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine($"Enter #{i} contract data: ");
            Console.WriteLine("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());
            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine();
        Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
        string monthYear = Console.ReadLine();

        int month = int.Parse(monthYear.Substring(0, 2));
        int year = int.Parse(monthYear.Substring(3));

        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Department: " + worker.Department.DeptName);
        Console.WriteLine("Income for " + monthYear + ": "
            + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture) + "€");

    }
}