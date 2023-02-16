using Cafe.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Cafe.DAL.EF
{
    public class CafeDbContext : DbContext
    {
        public DbSet<GroupProducts> GroupProducts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<IngredientsInProducts> IngredientsInProducts { get; set; }
        public CafeDbContext(DbContextOptions options) : base(options)
        {
            // Для заполнения БД
           DbInitializer.Initialize(this);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ingredients>()
            .HasOne(p => p.GroupProduct)
            .WithMany(t => t.Ingredients)
            .HasForeignKey(i => i.GroupProductId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<IngredientsInProducts>()
            .HasOne(p => p.Ingredient)
            .WithMany(t => t.IngredientsInProducts)
            .HasForeignKey(i => i.IngredientId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<IngredientsInProducts>()
                .HasOne(p => p.Product)
                .WithMany(t => t.Ingredients)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(builder);
        }

    }
}
