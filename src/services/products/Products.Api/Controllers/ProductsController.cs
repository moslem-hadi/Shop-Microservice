using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Domain;

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        private readonly IReadUnitOfWork _readUnitOfWork;
        public ProductsController(IReadUnitOfWork readUnitOfWork)
        {
            _readUnitOfWork = readUnitOfWork;
        }
        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await _readUnitOfWork.ProductReadRepository.GetAllAsync();
        }
    }
}
