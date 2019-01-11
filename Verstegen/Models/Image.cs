using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        
        public string ImgUrl { get; set; }

        public string AltString { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
