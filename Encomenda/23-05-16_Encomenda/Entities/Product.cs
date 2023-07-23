using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_16_Encomenda.Entities
{
    internal class Product
    {
        // PROPRIEDADES
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        // CONSTRUTORES
        public Product()
        {            
        }

        public Product(string productName, double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
