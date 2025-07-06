using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Taskify.DataAccess.Models;
using Taskify.Utilities;

namespace Taskify.DataAccess.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);

            builder.Entity<UserProject>()
            .HasKey(up => new { up.UserId, up.ProjectId });

            builder.Entity<UserProject>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserProjects)
                .HasForeignKey(up => up.UserId);

            builder.Entity<UserProject>()
                .HasOne(up => up.Project)
                .WithMany(p => p.UserProjects)
                .HasForeignKey(up => up.ProjectId);
        }
        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>()
                .HasData
                (
                     new IdentityRole() { Name = SD.Role_Admin, ConcurrencyStamp = "1", NormalizedName = SD.Role_Admin },
                     new IdentityRole() { Name = SD.Role_User, ConcurrencyStamp = "2", NormalizedName = SD.Role_User }
                );
        }
    }
}
