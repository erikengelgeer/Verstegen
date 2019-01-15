using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string SubTitle { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string AmountOfPeople { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        [Required]
        public string Procedure { get; set; }

        [Required]
        public string Decoration { get; set; }

        public int ThemeId { get; set; }
        public Theme Theme { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }

    public class Ingredient
    {
        public int IngredientId { get; set; }

        [Required]
        public String Name { get; set; }


        public int? ArticleNumber { get; set; }

        [Required]
        public int Gram { get; set; }

        [Required]
        public double Percentage { get; set; }

        [Required]
        public int RecipeId { get; set; }

        [Required]
        public Recipe Recipe { get; set; }       
    }
}
