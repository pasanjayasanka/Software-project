using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Food_Application.Models
{
    public class Farmer
    {
        [Key]
        public int FarmerID { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
        public int FoodID { get; set; }

    }
}
