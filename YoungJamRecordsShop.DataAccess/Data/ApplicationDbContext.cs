using Microsoft.EntityFrameworkCore;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Album> Album { get; set; }
    }
}