using Microsoft.EntityFrameworkCore;
using DAL.Model;

namespace DAL.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        DbSet<Route> Routes { get; set; }
        DbSet<Driver> Drivers { get; set; }
        DbSet<Package> Packages { get; set; }
        DbSet<DriveLicense> DriverLicenses { get; set; }
       
    }
  
}
