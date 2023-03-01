using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class DriveLicense
    {
        public int Id { get; set; }

        [StringLength(10, ErrorMessage = "Type Code Length is 10")]
        public string Code { get; set; } = string.Empty;

        [StringLength(2, ErrorMessage = "Type Max Length is 2")]
        public string Type { get; set; } = string.Empty;

        public DateTime Expiration { get; set; }
        public DateTime Release { get; set; }
        public Driver Driver { get; set; } = new Driver();
    }
}