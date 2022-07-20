using Microsoft.EntityFrameworkCore;
using MDTC.Models;
namespace MDTC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Calc> Calcs { get; set; }
    }
}
