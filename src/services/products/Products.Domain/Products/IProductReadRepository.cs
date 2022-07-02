namespace Products.Domain
{
    public interface IProductReadRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetAsync(int id);
    }
}
