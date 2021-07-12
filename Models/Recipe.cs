using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        [Display(Name = "Cook Time")]
        public int Cook_Time { get; set; }
        [Column(TypeName = "string")]
        [Display(Name = "Image Path")]
        public string Image_Path { get; set; }
    }
}
