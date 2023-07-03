using backend_ecommerce.src.Backoffice.Products.Domain;
using backend_ecommerce.Src.Shared.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace backend_ecommerce.src.Backoffice.Products.Infrastructure.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContextFactory _contextFactory;

        public ProductRepository(DatabaseContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Product> Find(ProductId productId)
        {
            using DatabaseContext context = _contextFactory.CreateDbContext();

            return await context.Products.FirstOrDefaultAsync(x => x.Id == productId);
        }

        public Task<List<Product>> FindAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            using DatabaseContext context = _contextFactory.CreateDbContext();
            context.Products.Add(product);
        }

        public async void Delete(ProductId productId)
        {
            using DatabaseContext context = _contextFactory.CreateDbContext();
        }

        public void Update(Product product, ProductId productId)
        {
            using DatabaseContext context = _contextFactory.CreateDbContext();
            throw new NotImplementedException();
        }
    }
}
