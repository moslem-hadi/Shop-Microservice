using Products.Domain;

namespace Products.Infrastructure.Products
{
    public class ProductWriteRepository : IProductWriteRepository
    {
        //TODO: SHOULD USE GENERIC REPOSITORY
        private readonly ProductDbContext _dbContext;
        public ProductWriteRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Product> AddAsync(Product product)
        {
            var productEntry = await _dbContext.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return productEntry.Entity;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            var productEntry = _dbContext.Update(product);


            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task DeleteAsync(Product product)
        {

            _dbContext.Products.Remove(product);

            await _dbContext.SaveChangesAsync();
        }

    }
}
