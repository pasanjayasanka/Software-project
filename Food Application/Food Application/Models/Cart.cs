using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Application.Models
{
    public class Cart
    {
        
        public int ProductID { get; set; }
        public int NumOfProducts { get; set; }
        public int TotalPrice { get; set; }
    }
}
