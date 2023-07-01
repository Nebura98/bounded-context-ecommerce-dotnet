namespace backend_ecommerce.src.Backoffice.Products.Domain
{
    public class Product
    {
        public ProductId ProductId { get; set; }
        public ProductName ProductName { get; set; }

        public Product(Guid Id, string Name)
        {
            ProductId = new ProductId(Id);
            ProductName = new ProductName(Name);

        }
    }
}