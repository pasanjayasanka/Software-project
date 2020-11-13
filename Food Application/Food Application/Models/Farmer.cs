using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Food_Application.Models
{
    public class Farmer
    {
        
        public int FarmerID { get; set; }
        public string FarmerFName { get; set; }
        public string FarmerLName { get; set; }
        public string Address { get; set; }
        public string ASCRNo { get; set; }
        public string AgriBranch { get; set; }
        public string NIC { get; set; }

        public int Phone { get; set; }

    }
}
