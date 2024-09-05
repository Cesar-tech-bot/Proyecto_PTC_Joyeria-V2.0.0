using SistemaJoyería.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyeria.Model.DTO
{
    public class SupplierDTO : dbContext
    {
        public int IDSupplier { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Direction { get; set; }
    }
}
