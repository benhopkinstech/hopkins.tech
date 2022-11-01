using hopkins.tech.Shared;
using Microsoft.EntityFrameworkCore;

namespace hopkins.tech.Server.Data
{
    public class HopkinsTechContext : DbContext
    {
        public HopkinsTechContext(DbContextOptions<HopkinsTechContext> options) : base(options)
        {
        }

        public DbSet<IndexData> Index { get; set; } = default!;
        public DbSet<SocialIcon> SocialIcons { get; set; } = default!;
        public DbSet<BlogData> Blogs { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IndexData>().ToTable("Index");
            modelBuilder.Entity<SocialIcon>().ToTable("SocialIcons");
            modelBuilder.Entity<BlogData>().ToTable("Blogs");
        }
    }
}
