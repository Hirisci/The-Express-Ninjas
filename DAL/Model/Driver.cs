using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class Driver
    {
        public int Id { get; set; }
        [StringLength(25, ErrorMessage = "Name Max Length is 25")]
        public string Name { get; set; } = string.Empty;
        [StringLength(25, ErrorMessage = "Name Surname Length is 25")]
        public string Surname { get; set; } = string.Empty;
        public string img { get; set; } = string.Empty;
        public ICollection<DriveLicense> DriverLicenses { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}