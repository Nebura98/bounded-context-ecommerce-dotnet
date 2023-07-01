namespace backend_ecommerce.src.Backoffice.Products.Domain
{
    public interface IProductRepository
    {
        public Task<Product> Find(ProductId productId);
        public Task<List<Product>> FindAll();
        public void Add(Product product);
        public void Update(Product product, ProductId productId);
        public void Delete(ProductId productId);
    }
}
