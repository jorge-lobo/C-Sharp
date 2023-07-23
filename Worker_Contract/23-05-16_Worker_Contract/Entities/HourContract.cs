using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_16_Worker_Contract.Entities
{
    internal class HourContract
    {
        // PROPRIEDADES
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //CONSTRUTORES
        public HourContract() 
        { 
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //MÉTODOS
        public double TotalValue()
        { 
            return ValuePerHour * Hours; 
        }

    }
}
