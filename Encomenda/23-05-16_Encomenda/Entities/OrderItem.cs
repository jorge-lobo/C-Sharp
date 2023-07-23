using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _23_05_16_Encomenda.Entities
{
    internal class OrderItem
    {
        // PROPRIEDADES
        public Product Product { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }

        // CONSTRUTORES
        public OrderItem()
        {
        }

        public OrderItem(Product product, double productPrice, int quantity)
        {
            Product = product;
            ProductPrice = productPrice;
            Quantity = quantity;
        }

        // MÉTODOS
        public double SubTotal()
        {
            return Quantity * ProductPrice;
        }
        public override string ToString()
        {
            return "Product: " + Product.ProductName + ", Quantity: " + Quantity
                + ", Price: " + ProductPrice.ToString("F2", CultureInfo.InvariantCulture) + "€"
                + ", Subtotal: " + SubTotal();
        }


    }
}
