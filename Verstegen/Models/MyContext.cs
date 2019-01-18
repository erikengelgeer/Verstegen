using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductImage>().HasKey(sc => new { sc.ProductId, sc.ImageId });

            modelBuilder.Entity<ProductImage>()
                .HasOne<Product>(sc => sc.Product)
                .WithMany(s => s.ProductImages)
                .HasForeignKey(sc => sc.ProductId);


            modelBuilder.Entity<ProductImage>()
                .HasOne<Image>(sc => sc.Image)
                .WithMany(s => s.ProductImages)
                .HasForeignKey(sc => sc.ImageId);
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        
    }
}
