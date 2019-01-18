using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Contents { get; set; }

        [Required]
        public string ProductDetails { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        [Required]
        public string AltString { get; set; }

        public IList<ProductImage> ProductImages { get; set; }
    }
}
