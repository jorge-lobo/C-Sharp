using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_23_Produtos.Entities
{
    internal class ImportedProduct : Product
    {
        //Atributos
        public double CustomsFee { get; set; }

        //Construtores
        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        //Métodos
        public override string PriceTag()
        {
            return Name + Price + CustomsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string ToString()
        {
            return Name + " " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + "€ (Customs fee: " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + "€)";
        }

    }
}
