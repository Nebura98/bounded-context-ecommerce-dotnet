using System.ComponentModel.DataAnnotations;
using backend_ecommerce.Src.Shared.Domain;

namespace backend_ecommerce.src.Backoffice.Products.Domain
{
    public class ProductPrice : ValueObject
    {
        [Required]
        public decimal? Price { get; private set; }

        public ProductPrice(decimal? price)
        {
            Price = price;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Price;
        }
    }
}
