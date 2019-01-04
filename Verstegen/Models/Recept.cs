using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class Recept
    {
        public int ReceptId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        public ICollection<ArticleAmount> Articles { get; set; }
    }

    public class ArticleAmount
    {
        public int ArticleAmountId { get; set; }

        [Required]
        public int Gram { get; set; }

        [Required]
        public double Percentage { get; set; }

        [Required]
        public Article Article { get; set; }

        [Required]
        public Recept Recept { get; set; }
    }

    public class Article
    {
        public int ArticleId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        public ICollection<ArticleAmount> Amounts { get; set; }
    }
}
