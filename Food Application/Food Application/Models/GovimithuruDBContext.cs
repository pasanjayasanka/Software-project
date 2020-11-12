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
        public DbSet<FoodItem>FoodItemsTable { get; set; }
        public DbSet<Farmer> FarmerTable { get; set; }
        public DbSet<Admin> AdminTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
    }
}
