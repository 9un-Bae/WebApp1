using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public string? Brand { get; set; }
    }
}