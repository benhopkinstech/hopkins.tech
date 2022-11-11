using hopkins.tech.Shared;
using Microsoft.EntityFrameworkCore;

namespace hopkins.tech.Server.Data
{
    public class HopkinsTechContext : DbContext
    {
        public HopkinsTechContext(DbContextOptions<HopkinsTechContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<BlogData> Blogs { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<BlogData>().ToTable("Blogs");
        }
    }
}
