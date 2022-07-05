namespace Products.Domain
{
    public interface IProductReadRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetAsync(int id);
        Task<Product> GetAsyncNoTracking(int id);
        Task<Tuple<List<Product>, int>> GetByFilterPagedAsync(ProductFilterPageReqDto request);
    }
}
