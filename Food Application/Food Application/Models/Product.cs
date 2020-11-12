using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Application.Models
{
    public class Product
    {
        [key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public string Picture { get; set; }
        public int ReorderLevel { get; set; }
        public float Quantity { get; set; }
        public string Addresse { get; set; }
        public string CategoryName { get; set; }
        public string ProductDescription { get; set; }
        public float UnitPrice { get; set; }
        public float UnitWeight { get; set; }
    }
}
