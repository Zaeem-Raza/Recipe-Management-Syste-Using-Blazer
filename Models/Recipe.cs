using System.ComponentModel.DataAnnotations;

namespace EAD_Assignment2.Models.Classes
{
    public class Recipe
    {
        
        public string? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Ingredients { get; set; }
        [Required]
        public string Category { get; set; }
    }
}