using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.Create;
using Products.Domain;

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IMapper _mapper { get; }
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMediator _mediator;

        public ProductsController(IReadUnitOfWork readUnitOfWork, IMapper mapper, IMediator mediatr)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
            _mediator = mediatr;
        }


        [HttpGet]
        public async Task<List<ProductResDto>> Get()
        {
            return _mapper.Map<List<ProductResDto>>(await _readUnitOfWork.ProductReadRepository.GetAllAsync());
        }
        [HttpPost]
        public async Task<ProductResDto> Post(AddProductCommand model)
        {
            return await _mediator.Send(model);
        }
    }
}
