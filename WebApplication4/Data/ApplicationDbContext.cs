using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<FakeTable> FakeTable {  get; set; }

    }
}
