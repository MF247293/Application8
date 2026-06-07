using Application08_TodoDB.Models;
using Microsoft.EntityFrameworkCore;

namespace Application08_TodoDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}