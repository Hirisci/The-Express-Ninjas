using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Package
    {
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; } = "Italia";
        public string Statuts { get; set; } = string.Empty;
        
        //Relazioni
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
