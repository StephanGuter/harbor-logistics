using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using harbor_logistics.Models.Enums;

namespace harbor_logistics.Models
{
    public class Container
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public ContainerStatus Status { get; set; }

        public ContainerCategory Category { get; set; }

        public ContainerType Type { get; set; }

        public ICollection<Movement> Movements { get; set; } = new List<Movement>();

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Container() { }

        public Container(int id, string code, ContainerStatus status, ContainerCategory category, ContainerType type, Customer customer)
        {
            Id = id;
            Code = code;
            Status = status;
            Category = category;
            Type = type;
            Customer = customer;
        }
    }
}