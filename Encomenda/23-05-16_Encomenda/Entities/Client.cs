using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_16_Encomenda.Entities
{
    internal class Client
    {
        // PROPRIEDADES
        public string ClientName { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDate { get; set; }

        // CONSTRUTORES
        public Client()
        {            
        }

        public Client(string clientName, string email, DateOnly birthDate)
        {
            ClientName = clientName;
            Email = email;
            BirthDate = birthDate;
        }


        public override string ToString()
        {
            return ClientName + ", " + Email
                + ", " + BirthDate.ToString("dd/MM/yyyy");
        }
    }
}
