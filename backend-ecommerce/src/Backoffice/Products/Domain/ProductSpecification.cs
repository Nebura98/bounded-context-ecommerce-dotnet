using System.ComponentModel.DataAnnotations;
using backend_ecommerce.Src.Shared.Domain;

namespace backend_ecommerce.src.Backoffice.Products.Domain
{
    public class ProductSpecification : ValueObject
    {
        
        [Required]
        public string Key { get; private set; }
        
        [Required]
        public string Value { get; private set; }

        public ProductSpecification(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
