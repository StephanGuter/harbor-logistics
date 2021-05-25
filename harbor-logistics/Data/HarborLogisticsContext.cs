using harbor_logistics.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harbor_logistics.Data
{
    public class HarborLogisticsContext : DbContext
    {
        public HarborLogisticsContext(DbContextOptions<HarborLogisticsContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Container> Container { get; set; }
        public DbSet<Movement> Movement { get; set; }
    }
}
