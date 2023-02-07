using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; } = String.Empty;

        public ICollection<User> Users { get; set; }
        
        
    }
}
