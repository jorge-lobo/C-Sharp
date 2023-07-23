using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_23_Produtos.Entities
{
    internal class UsedProduct : Product
    {
        //Atributos
        public DateOnly ManufactureDate { get; set; }

        //Construtores
        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateOnly manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        //Métodos
        public override string PriceTag()
        {
            return Name + Price + ManufactureDate.ToString();
        }
        public override string ToString()
        {
            return Name + " (used) " + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + "€ (Manufacture date: " + ManufactureDate + ")";
        }
    }
}
