using BásicoFacil.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace BásicoFacil.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserData> Data { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            base.OnModelCreating(modelBuilder);
        }
    }
}
