namespace Products.Domain
{
    public interface IProductWriteRepository
    {
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task DeleteAsync(Product product);

    }
}
