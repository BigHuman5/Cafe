using Cafe.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Cafe.DAL.EF
{
    public class CafeDbContext : DbContext
    {
        public DbSet<GroupProducts> GroupProducts { get; set; }
        public DbSet<Products> Products { get; set; }
        public CafeDbContext(DbContextOptions options) : base(options)
        {
            // Для заполнения БД
            DbInitializer.Initialize(this);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
