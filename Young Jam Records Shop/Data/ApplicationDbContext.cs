using Microsoft.EntityFrameworkCore;
using Young_Jam_Records_Shop.Model;

namespace Young_Jam_Records_Shop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Album> Album { get; set; }
    }
}