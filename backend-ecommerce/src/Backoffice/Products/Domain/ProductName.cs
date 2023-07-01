using System.ComponentModel.DataAnnotations;

using backend_ecommerce.Src.Shared.Domain;

namespace backend_ecommerce.src.Backoffice.Products.Domain
{
    public class ProductName : ValueObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es requerido")]
        [MinLength(5, ErrorMessage = "El número mínimo de caracteres permitidos es de 5")]
        [MaxLength(128, ErrorMessage = "El número máximo de caracteres permitidos es de 128")]
        public string Name { get; private set; }

        public ProductName(string name)
        {
            Name = name;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}
