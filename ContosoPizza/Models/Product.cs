using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizza.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Column(TypeName ="decimal(6,2)")]
        public decimal Price { get; set; } 
    }
}
