using backend_ecommerce.src.Shared.Domain.Aggregate;
using System.ComponentModel.DataAnnotations;

namespace backend_ecommerce.src.Backoffice.Products.Domain
{
    public class Product : AggregateRoot
    {
        [Required]
        public ProductName Name { get; set; }
        
        [Required]
        public ProductPrice Price { get; set; }

        public List<ProductSpecification>? Specifications { get; set; }

        public Product(Guid id, string name, decimal price)
        {
            Name = new ProductName(name);
            Price = new ProductPrice(price);
        }
    }
}