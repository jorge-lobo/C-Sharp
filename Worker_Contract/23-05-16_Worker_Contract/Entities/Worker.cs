using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _23_05_16_Worker_Contract.Entities.Enums;

namespace _23_05_16_Worker_Contract.Entities
{
    internal class Worker
    {
        // PROPRIEDADES
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // CONSTRUTORES
        public Worker()
        {
        }
        public Worker(string workerName, WorkerLevel level, double baseSalary, Department department)
        {
            Name = workerName;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // MÉTODOS
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double soma = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma += contract.TotalValue();
                }
            }
            return soma;
        }
    }
}
