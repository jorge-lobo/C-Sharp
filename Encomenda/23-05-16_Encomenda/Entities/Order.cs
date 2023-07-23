using _23_05_16_Encomenda.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _23_05_16_Encomenda.Entities
{
    internal class Order
    {
        // PROPRIEDADES
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        // CONSTRUTORES
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        // MÉTODOS
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        /*public override string ToString()
        {
            return  "ORDER SUMMARY: "
                + "\nOrder moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss")
                + "\nOrder status: " + Status + "Pending_Payment/Procesing/Shipped/Delivered"
                + "\nClient: " + Client
                + "\nOrder items: " + Items
                + "\nTotal price: " + Total().ToString("F2", CultureInfo.InvariantCulture) + "€";
        }*/

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total Price: " + Total().ToString("F2", CultureInfo.InvariantCulture) + "€");
            return sb.ToString();
        }










    }
}
