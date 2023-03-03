using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsDelivered { get; set;}

        //Relazioni
        public int? DriveId { get; set; }
        public Driver? Driver { get; set; }

        public int? RouteId { get; set; }
        public Route? Route { get; set; }
        
        ICollection<Package> Packages { get; set; } = new List<Package>();
    }
}
