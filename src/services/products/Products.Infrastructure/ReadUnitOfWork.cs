using Products.Domain;
using Products.Infrastructure.Products;

namespace Products.Infrastructure
{
    //TODO: USE GENERIC
    public class ReadUnitOfWork : IReadUnitOfWork
    {
        private IProductReadRepository _productReadRepository;
        private readonly ProductDbContext _context;
        public ReadUnitOfWork(ProductDbContext context)
        {
            _context = context;
        }

        public IProductReadRepository ProductReadRepository
        {
            get {
                return _productReadRepository ??= new ProductReadRepository(_context);
            }
        }
    }
}
