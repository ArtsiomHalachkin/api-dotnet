using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public string InternalSecretCode { get; set; } 
    }
}
