using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Application.Models
{
    public class OrderDetails
    {
        
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float UnitPrice { get; set; }
        public float Quantity { get; set; }
        public int OrderNumber { get; set; }

    }
}
