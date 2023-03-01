using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Model
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string img { get; set; } = string.Empty;
        public DriveLicense? DriveLicense { get; set; }
    }
}