using Products.Domain;
using Products.Infrastructure.Products;

namespace Products.Infrastructure
{
    public class WriteUnitOfWork : IWriteUnitOfWork
    {
        private readonly ProductDbContext _context;

        public WriteUnitOfWork(ProductDbContext context)
        {
            _context = context;
        }
        private ProductWriteRepository _productWriteRepository;

        public IProductWriteRepository ProductWriteRepository
        {
            get
            {
                return _productWriteRepository ??= new ProductWriteRepository(_context);
            }
        }


    }
}
