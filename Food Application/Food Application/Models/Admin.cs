using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Application.Models
{
    public class Admin
    {
        [key]
        public int AdminId { get; set; }
        public string AdminFName { get; set; }
        public string AdminLName { get; set; }
        public string Password { get; set; }

    }
}
