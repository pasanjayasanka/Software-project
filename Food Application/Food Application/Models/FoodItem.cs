using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Food_Application.Models
{
    public class FoodItem
    {
        [Key]
        public int FoodID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }
        public string Location { get; set; }
        public int FarmerID{ get; set; }


    }

    internal class keyAttribute : Attribute
    {
    }
}
