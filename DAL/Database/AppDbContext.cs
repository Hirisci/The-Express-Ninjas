using Microsoft.EntityFrameworkCore;

namespace DAL.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       
    }
  
}
