using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harbor_logistics.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string CNPJ { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public ICollection<Container> Containers { get; set; } = new List<Container>();

        public Customer() { }

        public Customer(int id, string cNPJ, string name, string phoneNumber, DateTime registrationDate)
        {
            Id = id;
            CNPJ = cNPJ;
            Name = name;
            PhoneNumber = phoneNumber;
            RegistrationDate = registrationDate;
        }
    }
}