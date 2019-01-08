using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Verstegen.Models;

namespace Verstegen.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Subtitle { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }

    public class BlogCategory
    {
        public int BlogCategoryId { get; set;}

        [ForeignKey("BlogID")]
        public Blog Blog { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
