using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models
{
    public class PizzaBase
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        
    }
}
