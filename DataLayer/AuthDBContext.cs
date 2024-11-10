using System.Security.Cryptography.X509Certificates;
using BasicMVC.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer
{
    public class AuthDBContext : IdentityDbContext<MVCUser>
    {
        public DbSet<MVCUser> MVCUsers { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Comment> Commetns { get; set; }
        public AuthDBContext(DbContextOptions<AuthDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
