using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Route
    {
        public int Id { get; set; }
        public  DateTime Date { get; set; }
        public bool IsOpen { get; set; }
        public Driver? Driver { get; set; }
    }
}
