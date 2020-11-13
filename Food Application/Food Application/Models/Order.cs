using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Application.Models
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public float Quantity { get; set; }
        public string RequiredDate { get; set; }
        public string OrderdDate { get; set; }
        public int OrderNumber { get; set; }
        
    }
}
