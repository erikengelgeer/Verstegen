using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategorys { get; set; }
        public DbSet<Category> Categorys { get; set; }

        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=srv-h-se-wdpr-a.database.windows.net;Initial Catalog=grp2;User ID=grp2;Password=2osajposlwA;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
