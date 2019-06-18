using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SeaBlog.Authorization.Roles;
using SeaBlog.Authorization.Users;
using SeaBlog.MultiTenancy;
using SeaBlog.BlogEntitys;

namespace SeaBlog.EntityFrameworkCore
{
    public class SeaBlogDbContext : AbpZeroDbContext<Tenant, Role, User, SeaBlogDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SeaBlogDbContext(DbContextOptions<SeaBlogDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogCategory>()
                .HasKey(bc => new { bc.BlogID, bc.CategoryID });

            modelBuilder.Entity<BlogCategory>()
                .HasOne(bc => bc.Blog)
                .WithMany(b => b.BlogCategories)
                .HasForeignKey(bc => bc.BlogID);

            modelBuilder.Entity<BlogCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BlogCategories)
                .HasForeignKey(bc => bc.CategoryID);

            modelBuilder.Entity<Blog>()
                .HasOne(b => b.CreatorUser)
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.CreatorUserId);

            modelBuilder.Entity<User>()
                .ToTable("User");

            modelBuilder.Entity<Blog>().Property(b => b.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Category>().Property(c => c.IsDeleted).HasDefaultValue(false);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
