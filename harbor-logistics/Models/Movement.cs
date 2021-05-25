using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using harbor_logistics.Models.Enums;

namespace harbor_logistics.Models
{
    public class Movement
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovementType Type { get; set; }

        public Container Container { get; set; }
        public int ContainerId { get; set; }

        public Movement() { }

        public Movement(int id, DateTime startDate, DateTime endDate, MovementType type, Container container)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Type = type;
            Container = container;
        }
    }
}