using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_23_Produtos.Entities
{
    internal class Product
    {
        //Atributos
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtores
        public Product()
        {
            
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //Métodos
        public virtual string PriceTag()
        {
            return Name + Price;
        }

        public override string ToString()
        {
            return Name + " " + Price.ToString("F2", CultureInfo.InvariantCulture) + "€";
        }

    }
}
