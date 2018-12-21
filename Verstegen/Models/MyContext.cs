using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Recept> Recipes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleAmount> ArticleAmounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=srv-h-se-wdpr-a.database.windows.net;Initial Catalog=grp2;User ID=grp2;Password=2osajposlwA;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
