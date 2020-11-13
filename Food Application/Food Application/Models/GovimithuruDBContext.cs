using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Food_Application.Models
{
    public class GovimithuruDBContext :DbContext 
    {
        public GovimithuruDBContext(DbContextOptions<GovimithuruDBContext> options)
            :base(options)
        {

        }
        
        public DbSet<Admin> AdminTable { get; set; }
        public DbSet<Customer> CustomerTable { get; set; }

        public DbSet<Farmer> FarmerTable { get; set; }
        public DbSet<Order> OrderTable { get; set; }
        public DbSet<OrderDetails> OrderDetailsTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
    }
}
